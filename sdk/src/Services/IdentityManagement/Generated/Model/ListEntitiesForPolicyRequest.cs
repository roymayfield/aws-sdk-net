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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListEntitiesForPolicy operation.
    /// Lists all users, groups, and roles that the specified managed policy is attached to.
    /// 
    /// 
    ///  
    /// <para>
    /// You can use the optional <code>EntityFilter</code> parameter to limit the results
    /// to a particular type of entity (users, groups, or roles). For example, to list only
    /// the roles that are attached to the specified policy, set <code>EntityFilter</code>
    /// to <code>Role</code>. 
    /// </para>
    ///  
    /// <para>
    /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
    /// parameters. 
    /// </para>
    /// </summary>
    public partial class ListEntitiesForPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private EntityType _entityFilter;
        private string _marker;
        private int? _maxItems;
        private string _pathPrefix;
        private string _policyArn;

        /// <summary>
        /// Gets and sets the property EntityFilter. 
        /// <para>
        /// The entity type to use for filtering the results. 
        /// </para>
        ///  
        /// <para>
        /// For example, when <code>EntityFilter</code> is <code>Role</code>, only the roles that
        /// are attached to the specified policy are returned. This parameter is optional. If
        /// it is not included, all attached entities (users, groups, and roles) are returned.
        /// 
        /// </para>
        /// </summary>
        public EntityType EntityFilter
        {
            get { return this._entityFilter; }
            set { this._entityFilter = value; }
        }

        // Check to see if EntityFilter property is set
        internal bool IsSetEntityFilter()
        {
            return this._entityFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter only when paginating results and only after you have received a
        /// response where the results are truncated. Set it to the value of the <code>Marker</code>
        /// element in the response you just received.
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
        /// Use this only when paginating results to indicate the maximum number of items you
        /// want in the response. If there are additional items beyond the maximum you specify,
        /// the <code>IsTruncated</code> response element is <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If you do not include it, it defaults to 100.
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

        /// <summary>
        /// Gets and sets the property PathPrefix. 
        /// <para>
        /// The path prefix for filtering the results. This parameter is optional. If it is not
        /// included, it defaults to a slash (/), listing all entities.
        /// </para>
        /// </summary>
        public string PathPrefix
        {
            get { return this._pathPrefix; }
            set { this._pathPrefix = value; }
        }

        // Check to see if PathPrefix property is set
        internal bool IsSetPathPrefix()
        {
            return this._pathPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

    }
}