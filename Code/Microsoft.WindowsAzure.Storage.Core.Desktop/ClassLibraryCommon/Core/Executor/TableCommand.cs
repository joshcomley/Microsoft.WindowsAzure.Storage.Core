//-----------------------------------------------------------------------
// <copyright file="TableCommand.cs" company="Microsoft">
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

namespace Microsoft.WindowsAzure.Storage.Core.Executor
{
#if WINDOWS_DESKTOP && !WINDOWS_PHONE
    using Microsoft.WindowsAzure.Storage.Table.DataServices;
    using System;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Reviewed.")]
    [Obsolete("Support for accessing Windows Azure Tables via WCF Data Services is now obsolete. It's recommended that you use the Microsoft.WindowsAzure.Storage.Table namespace for working with tables.")]
    internal class TableCommand<T, INTERMEDIATE_TYPE> : StorageCommandBase<T>
    {
        public Func<INTERMEDIATE_TYPE> ExecuteFunc;
        public Func<AsyncCallback, object, IAsyncResult> Begin;
        public Func<IAsyncResult, INTERMEDIATE_TYPE> End;
        public Func<INTERMEDIATE_TYPE, RequestResult, TableCommand<T, INTERMEDIATE_TYPE>, T> ParseResponse;
        public TableServiceContext Context = null;
    }
#endif
}
