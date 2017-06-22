// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Represent a sync group log object.
    /// </summary>
    public partial class SyncGroupLog
    {
        private string _details;
        
        /// <summary>
        /// Optional. Content of the log.
        /// </summary>
        public string Details
        {
            get { return this._details; }
            set { this._details = value; }
        }
        
        private string _source;
        
        /// <summary>
        /// Optional. Source of the sync group log.
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }
        
        private System.DateTime? _timeStamp;
        
        /// <summary>
        /// Optional. Time stamp of the log.
        /// </summary>
        public System.DateTime? TimeStamp
        {
            get { return this._timeStamp; }
            set { this._timeStamp = value; }
        }
        
        private Microsoft.Azure.Management.Sql.LegacySdk.Models.LogType? _type;
        
        /// <summary>
        /// Optional. Type of the log. The possible values: 'Error', 'Warning',
        /// 'Success' and 'All'.
        /// </summary>
        public Microsoft.Azure.Management.Sql.LegacySdk.Models.LogType? Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SyncGroupLog class.
        /// </summary>
        public SyncGroupLog()
        {
        }
    }
}
