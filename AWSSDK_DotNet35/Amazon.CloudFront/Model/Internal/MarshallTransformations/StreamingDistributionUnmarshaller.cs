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
using System.Collections.Generic;

using Amazon.CloudFront.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   StreamingDistribution Unmarshaller
     /// </summary>
    internal class StreamingDistributionUnmarshaller : IUnmarshaller<StreamingDistribution, XmlUnmarshallerContext>, IUnmarshaller<StreamingDistribution, JsonUnmarshallerContext> 
    {
        public StreamingDistribution Unmarshall(XmlUnmarshallerContext context) 
        {
            StreamingDistribution streamingDistribution = new StreamingDistribution();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Id", targetDepth))
                    {
                        streamingDistribution.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        streamingDistribution.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("LastModifiedTime", targetDepth))
                    {
                        streamingDistribution.LastModifiedTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DomainName", targetDepth))
                    {
                        streamingDistribution.DomainName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ActiveTrustedSigners", targetDepth))
                    {
                        streamingDistribution.ActiveTrustedSigners = ActiveTrustedSignersUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("StreamingDistributionConfig", targetDepth))
                    {
                        streamingDistribution.StreamingDistributionConfig = StreamingDistributionConfigUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return streamingDistribution;
                }
            }
                        


            return streamingDistribution;
        }

        public StreamingDistribution Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static StreamingDistributionUnmarshaller instance;

        public static StreamingDistributionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new StreamingDistributionUnmarshaller();

            return instance;
        }
    }
}
    
