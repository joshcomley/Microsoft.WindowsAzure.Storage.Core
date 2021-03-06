//-----------------------------------------------------------------------
// <copyright file="SharedKeyLiteAuthenticationHandler.cs" company="Microsoft">
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
//-----------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Storage.Auth.Protocol
{
    using Microsoft.WindowsAzure.Storage.Core.Auth;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;

    /// <summary>
    /// Represents a handler that signs HTTP requests with a shared key.
    /// </summary>
    [Obsolete("Use SharedKeyAuthenticationHandler")]
    public sealed class SharedKeyLiteAuthenticationHandler : IAuthenticationHandler
    {
        private readonly SharedKeyAuthenticationHandler authenticationHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedKeyLiteAuthenticationHandler"/> class.
        /// </summary>
        /// <param name="canonicalizer">A canonicalizer that converts HTTP request data into a standard form appropriate for signing.</param>
        /// <param name="credentials">A <see cref="StorageCredentials"/> object providing credentials for the request.</param>
        /// <param name="resourceAccountName">The name of the storage account that the HTTP request will access.</param>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "canonicalizer", Justification = "Reviewed: Canonicalizer can be used as an identifier name.")]
        public SharedKeyLiteAuthenticationHandler(ICanonicalizer canonicalizer, StorageCredentials credentials, string resourceAccountName)
        {
            this.authenticationHandler = new SharedKeyAuthenticationHandler(canonicalizer, credentials, resourceAccountName);
        }

        /// <summary>
        /// Signs the specified HTTP request with a shared key.
        /// </summary>
        /// <param name="request">The HTTP request to sign.</param>
        /// <param name="operationContext">An <see cref="OperationContext"/> object that represents the context for the current operation.</param>
        public void SignRequest(HttpWebRequest request, OperationContext operationContext)
        {
            this.authenticationHandler.SignRequest(request, operationContext);
        }
    }
}
