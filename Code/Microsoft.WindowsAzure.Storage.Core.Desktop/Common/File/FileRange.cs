//-----------------------------------------------------------------------
// <copyright file="FileRange.cs" company="Microsoft">
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

namespace Microsoft.WindowsAzure.Storage.File
{
    using System.Globalization;

    /// <summary>
    /// Represents a range in a file.
    /// </summary>
    public sealed class FileRange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileRange"/> class.
        /// </summary>
        /// <param name="start">The starting offset.</param>
        /// <param name="end">The ending offset.</param>
        public FileRange(long start, long end)
        {
            this.StartOffset = start;
            this.EndOffset = end;
        }

        /// <summary>
        /// Gets the starting offset of the page range.
        /// </summary>
        /// <value>The starting offset.</value>
        public long StartOffset { get; internal set; }

        /// <summary>
        /// Gets the ending offset of the page range.
        /// </summary>
        /// <value>The ending offset.</value>
        public long EndOffset { get; internal set; }

        /// <summary>
        /// Returns the content of the range as a string.
        /// </summary>
        /// <returns>The content of the range.</returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "bytes={0}-{1}", this.StartOffset, this.EndOffset);
        }
    }
}
