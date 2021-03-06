// -----------------------------------------------------------------------------------------
// <copyright file="LoggingProperties.cs" company="Microsoft">
//    Copyright 2013 Microsoft Corporation
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//      http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
// -----------------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Storage.Shared.Protocol
{
    /// <summary>
    /// Class representing the service properties pertaining to logging.
    /// </summary>
    public sealed class LoggingProperties
    {
        /// <summary>
        /// Initializes a new instance of the LoggingProperties class.
        /// </summary>
        public LoggingProperties()
            : this(Constants.AnalyticsConstants.LoggingVersionV1)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LoggingProperties class.
        /// </summary>
        public LoggingProperties(string version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Gets or sets the version of the analytics service.
        /// </summary>
        /// <value>A string identifying the version of the service.</value>
        public string Version
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the state of logging.
        /// </summary>
        /// <value>A combination of <see cref="LoggingOperations"/> flags describing the operations that are logged.</value>
        public LoggingOperations LoggingOperations
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the logging retention policy.
        /// </summary>
        /// <value>The number of days to retain the logs.</value>
        public int? RetentionDays
        {
            get;
            set;
        }
    }
}
