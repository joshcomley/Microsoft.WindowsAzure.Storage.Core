// -----------------------------------------------------------------------------------------
// <copyright file="QueueMessageType.cs" company="Microsoft">
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

namespace Microsoft.WindowsAzure.Storage.Queue
{
    /// <summary>
    /// Enum for Queue message type.
    /// Internal use only. 
    /// </summary>
    internal enum QueueMessageType
    {
        /// <summary>
        /// Indicates the message object stores the raw text string.
        /// </summary>
        RawString,

        /// <summary>
        /// Indicates the message object stores the Base64-Encoded representation of the raw data. 
        /// </summary>
        Base64Encoded,

        /// <summary>
        /// Indicates the message object stores the raw binary data.
        /// </summary>
        RawBytes
    }
}
