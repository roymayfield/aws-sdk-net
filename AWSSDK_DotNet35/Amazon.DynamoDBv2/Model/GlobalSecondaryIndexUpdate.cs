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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents the new provisioned throughput settings to apply to a global secondary index.</para>
    /// </summary>
    public class GlobalSecondaryIndexUpdate
    {
        
        private UpdateGlobalSecondaryIndexAction update;


        /// <summary>
        /// The name of a global secondary index, along with the updated provisioned throughput settings that are to be applied to that index.
        ///  
        /// </summary>
        public UpdateGlobalSecondaryIndexAction Update
        {
            get { return this.update; }
            set { this.update = value; }
        }

        // Check to see if Update property is set
        internal bool IsSetUpdate()
        {
            return this.update != null;
        }
    }
}
