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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RedshiftDestinationUpdate Marshaller
    /// </summary>       
    public class RedshiftDestinationUpdateMarshaller : IRequestMarshaller<RedshiftDestinationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RedshiftDestinationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCloudWatchLoggingOptions())
            {
                context.Writer.WritePropertyName("CloudWatchLoggingOptions");
                context.Writer.WriteObjectStart();

                var marshaller = CloudWatchLoggingOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchLoggingOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetClusterJDBCURL())
            {
                context.Writer.WritePropertyName("ClusterJDBCURL");
                context.Writer.Write(requestObject.ClusterJDBCURL);
            }

            if(requestObject.IsSetCopyCommand())
            {
                context.Writer.WritePropertyName("CopyCommand");
                context.Writer.WriteObjectStart();

                var marshaller = CopyCommandMarshaller.Instance;
                marshaller.Marshall(requestObject.CopyCommand, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.Write(requestObject.Password);
            }

            if(requestObject.IsSetRetryOptions())
            {
                context.Writer.WritePropertyName("RetryOptions");
                context.Writer.WriteObjectStart();

                var marshaller = RedshiftRetryOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.RetryOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRoleARN())
            {
                context.Writer.WritePropertyName("RoleARN");
                context.Writer.Write(requestObject.RoleARN);
            }

            if(requestObject.IsSetS3Update())
            {
                context.Writer.WritePropertyName("S3Update");
                context.Writer.WriteObjectStart();

                var marshaller = S3DestinationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Update, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.Write(requestObject.Username);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RedshiftDestinationUpdateMarshaller Instance = new RedshiftDestinationUpdateMarshaller();

    }
}