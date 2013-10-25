/*
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
    using System.Net;
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for ListPipelines operation
      /// </summary>
      internal class ListPipelinesResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          ListPipelinesResponse response = new ListPipelinesResponse();
          
          context.Read();
      
          response.ListPipelinesResult = ListPipelinesResultUnmarshaller.GetInstance().Unmarshall(context);
          
          return response;
        }
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
          {
            AccessDeniedException ex = new AccessDeniedException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServiceException"))
          {
            InternalServiceException ex = new InternalServiceException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
          {
            ValidationException ex = new ValidationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("IncompatibleVersionException"))
          {
            IncompatibleVersionException ex = new IncompatibleVersionException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          return new AmazonElasticTranscoderException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static ListPipelinesResponseUnmarshaller instance;
        public static ListPipelinesResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new ListPipelinesResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  