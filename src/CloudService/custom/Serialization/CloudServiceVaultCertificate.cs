﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json;

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models
{
    public partial class CloudServiceVaultCertificate
    {
        partial void OverrideToString(ref string stringResult, ref bool returnNow)
        {
            stringResult =  this.CertificateUrl;
        }
    }
}
