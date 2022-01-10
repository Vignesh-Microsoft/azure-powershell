﻿// ----------------------------------------------------------------------------------
//
// Copyright 2012 Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Commands.Storage.Test.Table
{
    using System;
    using System.Globalization;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.WindowsAzure.Commands.Storage.Common;
    using Microsoft.WindowsAzure.Commands.Storage.Table.Cmdlet;

    [TestClass]
    public class RemoveAzureStorageTableStoredAccessPolicyTest : StorageTableStorageTestBase
    {
        public RemoveAzureStorageTableStoredAccessPolicyCommand command = null;

        [TestInitialize]
        public void InitCommand()
        {
            command = new RemoveAzureStorageTableStoredAccessPolicyCommand(tableMock)
            {
                CommandRuntime = MockCmdRunTime
            };
        }

        [TestCleanup]
        public void CleanCommand()
        {
            this.clearTest();
            this.command = null;
        }

        [TestMethod]
        public void RemoveStoredAccessPolicyNotExistsTest()
        {
            ClearAndAddTestStoredAccessPolicies();
            string policyName = "Policy" + Guid.NewGuid();
            string tableName = "sampleTable";

            AssertThrows<ResourceNotFoundException>(() => command.RemoveAzureTableStoredAccessPolicy(tableMock, tableName, policyName),
                String.Format(CultureInfo.CurrentCulture, Resources.PolicyNotFound, policyName));
            clearTest();
        }

        [TestMethod]
        public void RemoveStoredAccessPolicySuccessTest()
        {
            ClearAndAddTestStoredAccessPolicies();
            string policyName = PolicyName1;
            string tableName = "sampleTable";

            command.RemoveAzureTableStoredAccessPolicy(tableMock, tableName, policyName);
            Assert.IsTrue(!tableMock.tablePermissions.SharedAccessPolicies.Keys.Contains(policyName));

            clearTest();
        }
    }
}
