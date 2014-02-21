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
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.DynamoDBv2.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// CapacityUnmarshaller
      /// </summary>
      internal class CapacityUnmarshaller : IUnmarshaller<Capacity, XmlUnmarshallerContext>, IUnmarshaller<Capacity, JsonUnmarshallerContext>
      {
        Capacity IUnmarshaller<Capacity, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Capacity Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            Capacity capacity = new Capacity();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("CapacityUnits", targetDepth))
              {
                context.Read();
                capacity.CapacityUnits = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return capacity;
                }
            }
          

            return capacity;
        }

        private static CapacityUnmarshaller instance;
        public static CapacityUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CapacityUnmarshaller();
            return instance;
        }
    }
}
  
