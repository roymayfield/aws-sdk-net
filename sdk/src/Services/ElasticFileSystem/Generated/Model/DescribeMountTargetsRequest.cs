/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the efs-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeMountTargets operation.
    /// Returns the descriptions of the current mount targets for a file system. The order
    /// of mount targets returned in the response is unspecified.
    /// 
    ///  
    /// <para>
    ///  This operation requires permission for the <code>elasticfilesystem:DescribeMountTargets</code>
    /// action on the file system <code>FileSystemId</code>. 
    /// </para>
    /// </summary>
    public partial class DescribeMountTargetsRequest : AmazonElasticFileSystemRequest
    {
        private string _fileSystemId;
        private string _marker;
        private int? _maxItems;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeMountTargetsRequest() { }

        /// <summary>
        /// Instantiates DescribeMountTargetsRequest with the parameterized properties
        /// </summary>
        /// <param name="fileSystemId">String. The ID of the file system whose mount targets you want to list.</param>
        public DescribeMountTargetsRequest(string fileSystemId)
        {
            _fileSystemId = fileSystemId;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// String. The ID of the file system whose mount targets you want to list.
        /// </para>
        /// </summary>
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Optional. String. Opaque pagination token returned from a previous <code>DescribeMountTargets</code>
        /// operation. If present, it specifies to continue the list from where the previous returning
        /// call left off.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Optional. Maximum number of mount targets to return in the response. It must be an
        /// integer with a value greater than zero.
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}