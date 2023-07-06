# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost If the code
# is regenerated.
# ----------------------------------------------------------------------------------

$ArtifactsFolder = "$PSScriptRoot/../../../artifacts"
$FilesChangedPaths = "$ArtifactsFolder/FilesChanged.txt"
$ExceptionFilePath = "$ArtifactsFolder/StaticAnalysisResults/GeneratedSdkIssues.csv"

Class GeneratedSdkIssue {
    [String]$Module
    [String]$Sdk
    [Int]$Severity
    [Int]$ProblemId
    [String]$Description
    [String]$Remediation
}

$ExceptionList = @()
$SavePath = $PWD

$MissReadMe = 9000
$GenSdkChanged = 9090
try{
    if ((Test-Path $FilesChangedPaths -PathType Leaf) -and $FilesChangedPaths.EndsWith(".txt")) {
        # Read Changedfiles and check if generted sdk code is updated.
        $FilesChanged = Get-Content $FilesChangedPaths | Where-Object { ($_ -match "^src\/.*\.Sdk\/.*Generated.*")}
        # Collect Sdk paths whose files under Generated folder change.
        $ChangedSdks = New-Object System.Collections.Generic.List[System.Object]
        foreach ($_ in $FilesChanged) {
            $ChangedSdks.Add($_.Substring(0,$_.IndexOf('.Sdk'))+'.Sdk')
        }
        # Remove duplicated Sdks.
        $ChangedSdks = $ChangedSdks | select -unique
    }
    else {
        Write-Warning "Only accept .txt files as input."
        return
    }
    Write-Host "Preparing Autorest..."
    npm install -g autorest@latest
    autorest --reset
    foreach ($_ in $ChangedSdks) {
        # Extract Module Name
        $ModuleName = "Az." + ($_ -split "\/|\\")[1]

        # Direct to the Sdk directory
        Write-Host "Directing to " "$PSScriptRoot/../../../$_"
        cd "$PSScriptRoot/../../../$_"

        # Regenerate the Sdk under Generated folder
        if( Test-Path -Path "README.md" -PathType Leaf){
            Write-Host "Re-generating SDK under Generated folder for $ModuleName..."
            autorest --use:@microsoft.azure/autorest.csharp@2.3.90
            autorest README.md --version=v2
        }
        else {
            $ExceptionList += [GeneratedSdkIssue]@{
                    Module = $ModuleName;
                    Sdk = $_;
                    Severity = 1;
                    ProblemId = $MissReadMe;
                    Description = "No README file detected under $_."
                    Remediation = "Make sure that the ReadMe file of Sdk is loaded."
            }
        }
        # See if the code is completely the same as we generated
        $changes = git status ".\Generated" --porcelain
        if ($changes -ne $null){
            $changes = $changes.replace("  ", "`n")
            $ExceptionList += [GeneratedSdkIssue]@{
                    Module = $ModuleName;
                    Sdk = $_;
                    Severity = 1;
                    ProblemId = $GenSdkChanged
                    Description = "Generated code for $ModuleName is not up to date or you have updated generated Sdk."
                    Remediation = "You may need to rebase on the latest main, regenerate code accroding to README.md file under $_, and make sure no more updates based on generated files."
            }
        }
        Set-Location $SavePath
    }
}
catch{
    Write-Host "Caught an error."
}
finally {
    Write-Host ""
    Write-Host "Summary:" 
    Write-Host ""
    Write-Host "  $($ExceptionList.Length) error(s) detected while verifying generated sdk:"
    Write-Host ""

    # foreach ($err in $ExceptionList) {
    #     Write-Host "error : " $err.Description "`n " $err.Remediation
    # }

    if ($ExceptionList.Length -ne 0) {
        $ExceptionList | Sort-Object -Unique -Property Module,Sdk,Description | Export-Csv $ExceptionFilePath -NoTypeInformation
    }
}
