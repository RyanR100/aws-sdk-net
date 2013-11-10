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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSigningCertificate operation.
    /// <para>Changes the status of the specified signing certificate from active to disabled, or vice versa. This action can be used to disable a
    /// user's signing certificate as part of a certificate rotation work flow.</para> <para>If the <c>UserName</c> field is not specified, the
    /// UserName is determined implicitly based on the AWS Access Key ID used to sign the request. Because this action works for access keys under
    /// the AWS account, this API can be used to manage root credentials even if the AWS account has no associated users.</para> <para>For
    /// information about rotating certificates, see <a
    /// href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/index.html?ManagingCredentials.html" >Managing Keys and Certificates</a> in
    /// <i>Using AWS Identity and Access Management</i> .</para>
    /// </summary>
    public partial class UpdateSigningCertificateRequest : AmazonWebServiceRequest
    {
        private string userName;
        private string certificateId;
        private StatusType status;

        /// <summary>
        /// Name of the user the signing certificate belongs to.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this.userName != null;
        }

        /// <summary>
        /// The ID of the signing certificate you want to update.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>24 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string CertificateId
        {
            get { return this.certificateId; }
            set { this.certificateId = value; }
        }

        // Check to see if CertificateId property is set
        internal bool IsSetCertificateId()
        {
            return this.certificateId != null;
        }

        /// <summary>
        /// The status you want to assign to the certificate. <c>Active</c> means the certificate can be used for API calls to AWS, while
        /// <c>Inactive</c> means the certificate cannot be used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Active, Inactive</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public StatusType Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

    }
}
    