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
using System.Linq;
using System.Text;

using Amazon.Util;

namespace Amazon.Runtime.Internal
{
    internal class StreamReadTracker
    {
        AmazonWebServiceClient client;
        EventHandler<StreamTransferProgressArgs> callback;
        long contentLength;
        long totalBytesRead;

        internal StreamReadTracker(AmazonWebServiceClient client, EventHandler<StreamTransferProgressArgs> callback, long contentLength)
        {
            this.client = client;
            this.callback = callback;
            this.contentLength = contentLength;
        }

        public void ReadProgress(int bytesRead)
        {
            if (callback == null)
                return;

            totalBytesRead += bytesRead;
            AWSSDKUtils.InvokeInBackground(
                                callback,
                                new StreamTransferProgressArgs(bytesRead, totalBytesRead, contentLength),
                                client);
        }
    }
}
