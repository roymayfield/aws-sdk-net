﻿/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;
using System.Text;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Represents a request being sent to an Amazon Web Service, including the
    /// parameters being sent as part of the request, the endpoint to which the
    /// request should be sent, etc.
    /// <para>
    /// This class is only intended for internal use inside the AWS client libraries.
    /// Callers shouldn't ever interact directly with objects of this class.
    /// </para>
    /// </summary>
    public interface IRequest
    {
        /// <summary>
        /// The name of the request
        /// </summary>
        string RequestName
        {
            get;
        }

        /// <summary>
        /// Returns a dictionary of the headers included in this request.
        /// </summary>
        IDictionary<string, string> Headers
        {
            get;
        }

        /// <summary>
        /// Gets and sets a flag that indicates whether the request is sent as a query string instead of the request body.
        /// </summary>
        bool UseQueryString
        {
            get;
            set;
        }

        /// <summary>
        /// Returns a dictionary of the parameters included in this request.
        /// </summary>
        IDictionary<String, String> Parameters
        {
            get;
        }

        /// <summary>
        /// Gets and sets the type of http request to make, whether it should be POST,GET or DELETE
        /// </summary>
        string HttpMethod
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and Sets the endpoint for this request.
        /// </summary>
        Uri Endpoint
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and Sets the resource path added on to the endpoint.
        /// </summary>
        string ResourcePath
        {
            get;
            set;
        }

        string CanonicalResource
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and Sets the content for this request.
        /// </summary>
        byte[] Content
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and sets the content stream.
        /// </summary>
        Stream ContentStream
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and sets the original stream position.
        /// If ContentStream is null or does not support seek, this propery
        /// should be equal to -1.
        /// </summary>
        long OriginalStreamPosition
        {
            get;
            set;
        }

        /// <summary>
        /// Computes the SHA 256 hash of the content stream. If the stream is not
        /// seekable, it searches the parent stream hierarchy to find a seekable
        /// stream prior to computation. Once computed, the hash is cached for future
        /// use.
        /// </summary>
        string ComputeContentStreamHash();

        /// <summary>
        /// The name of the service to which this request is being sent.
        /// </summary>
        string ServiceName
        {
            get;
        }

        /// <summary>
        /// Returns the original, user facing request object which this internal
        /// request object is representing.
        /// </summary>
        AmazonWebServiceRequest OriginalRequest
        {
            get;
        }

        /// <summary>
        /// Alternate endpoint to use for this request, if any.
        /// </summary>
        RegionEndpoint AlternateEndpoint
        {
            get;
            set;
        }

        /// <summary>
        /// Gets and sets the Suppress404Exceptions property. If true then 404s return back from AWS will not cause an exception and 
        /// an empty response object will be returned.
        /// </summary>
        bool Suppress404Exceptions
        {
            get;
            set;
        }

        /// <summary>
        /// If using AWS4 signing protocol, contains the resultant parts of the
        /// signature that we may need to make use of if we elect to do a chunked
        /// encoding upload.
        /// </summary>
        AWS4SigningResult AWS4SignerResult
        {
            get; 
            set;
        }

        /// <summary>
        /// Determine whether to use a chunked encoding upload for the request
        /// (applies to Amazon S3 PutObject and UploadPart requests only). 
        /// </summary>
        /// <returns></returns>
        bool UseChunkEncoding
        {
            get; 
            set;
        }
    }
}
