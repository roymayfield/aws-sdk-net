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
    /// Container for the parameters to the CopySnapshot operation.
    /// Copies a point-in-time snapshot of an EBS volume and stores it in Amazon S3. You can
    /// copy the snapshot within the same region or from one region to another. You can use
    /// the snapshot to create EBS volumes or Amazon Machine Images (AMIs). The snapshot is
    /// copied to the regional endpoint that you send the HTTP request to.
    /// 
    ///  
    /// <para>
    /// Copies of encrypted EBS snapshots remain encrypted. Copies of unencrypted snapshots
    /// remain unencrypted, unless the <code>Encrypted</code> flag is specified during the
    /// snapshot copy operation. By default, encrypted snapshot copies use the default AWS
    /// Key Management Service (KMS) master key; however, you can specify a non-default master
    /// key with the <code>KmsKeyId</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-copy-snapshot.html">Copying
    /// an Amazon EBS Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CopySnapshotRequest : AmazonEC2Request
    {
        private string _description;
        private string _destinationRegion;
        private bool? _encrypted;
        private string _kmsKeyId;
        private string _presignedUrl;
        private string _sourceRegion;
        private string _sourceSnapshotId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the EBS snapshot.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The destination region to use in the <code>PresignedUrl</code> parameter of a snapshot
        /// copy operation. This parameter is only valid for specifying the destination region
        /// in a <code>PresignedUrl</code> parameter, where it is required.
        /// </para>
        ///  <note> 
        /// <para>
        /// <code>CopySnapshot</code> sends the snapshot copy to the regional endpoint that you
        /// send the HTTP request to, such as <code>ec2.us-east-1.amazonaws.com</code> (in the
        /// AWS CLI, this is specified with the <code>--region</code> parameter or the default
        /// region in your AWS configuration file).
        /// </para>
        ///  </note>
        /// </summary>
        public string DestinationRegion
        {
            get { return this._destinationRegion; }
            set { this._destinationRegion = value; }
        }

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this._destinationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Specifies whether the destination snapshot should be encrypted. There is no way to
        /// create an unencrypted snapshot copy from an encrypted snapshot; however, you can encrypt
        /// a copy of an unencrypted snapshot with this flag. The default master key is used unless
        /// a non-default AWS Key Management Service (KMS) master key is specified with <code>KmsKeyId</code>.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The full ARN of the AWS Key Management Service (KMS) master key to use when creating
        /// the snapshot copy. This parameter is only required if you want to use a non-default
        /// master key; if this parameter is not specified, the default master key is used. The
        /// ARN contains the <code>arn:aws:kms</code> namespace, followed by the region of the
        /// master key, the AWS account ID of the master key owner, the <code>key</code> namespace,
        /// and then the master key ID. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:key/<i>abcd1234-a123-456a-a12b-a123b4cd56ef</i>.
        /// The specified key must exist in the region that the snapshot is being copied to. If
        /// a <code>KmsKeyId</code> is specified, the <code>Encrypted</code> flag must also be
        /// set.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property PresignedUrl. 
        /// <para>
        /// The pre-signed URL that facilitates copying an encrypted snapshot. This parameter
        /// is only required when copying an encrypted snapshot with the Amazon EC2 Query API;
        /// it is available as an optional parameter in all other cases. The <code>PresignedUrl</code>
        /// should use the snapshot source endpoint, the <code>CopySnapshot</code> action, and
        /// include the <code>SourceRegion</code>, <code>SourceSnapshotId</code>, and <code>DestinationRegion</code>
        /// parameters. The <code>PresignedUrl</code> must be signed using AWS Signature Version
        /// 4. Because EBS snapshots are stored in Amazon S3, the signing algorithm for this parameter
        /// uses the same logic that is described in <a href="http://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">Authenticating
        /// Requests by Using Query Parameters (AWS Signature Version 4)</a> in the <i>Amazon
        /// Simple Storage Service API Reference</i>. An invalid or improperly signed <code>PresignedUrl</code>
        /// will cause the copy operation to fail asynchronously, and the snapshot will move to
        /// an <code>error</code> state.
        /// </para>
        /// </summary>
        internal string PresignedUrl
        {
            get { return this._presignedUrl; }
            set { this._presignedUrl = value; }
        }

        // Check to see if PresignedUrl property is set
        internal bool IsSetPresignedUrl()
        {
            return this._presignedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The ID of the region that contains the snapshot to be copied.
        /// </para>
        /// </summary>
        public string SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSnapshotId. 
        /// <para>
        /// The ID of the EBS snapshot to copy.
        /// </para>
        /// </summary>
        public string SourceSnapshotId
        {
            get { return this._sourceSnapshotId; }
            set { this._sourceSnapshotId = value; }
        }

        // Check to see if SourceSnapshotId property is set
        internal bool IsSetSourceSnapshotId()
        {
            return this._sourceSnapshotId != null;
        }

    }
}