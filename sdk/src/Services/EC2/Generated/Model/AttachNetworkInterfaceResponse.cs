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
 * Do not modify this file. This file is generated from the ec2-2015-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AttachNetworkInterfaceResponse : AmazonWebServiceResponse
    {
        private string _attachmentId;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The ID of the network interface attachment.
        /// </para>
        /// </summary>
        public string AttachmentId
        {
            get { return this._attachmentId; }
            set { this._attachmentId = value; }
        }

        // Check to see if AttachmentId property is set
        internal bool IsSetAttachmentId()
        {
            return this._attachmentId != null;
        }

    }
}