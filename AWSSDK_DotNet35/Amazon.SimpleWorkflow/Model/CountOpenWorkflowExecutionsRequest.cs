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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the CountOpenWorkflowExecutions operation.
    /// <para> Returns the number of open workflow executions within the given domain that meet the specified filtering criteria. </para>
    /// <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and
    /// changes. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources
    /// as follows:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
    /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
    /// <ul>
    /// <li> <c>tagFilter.tag</c> : String constraint. The key is <c>swf:tagFilter.tag</c> .</li>
    /// <li> <c>typeFilter.name</c> : String constraint. The key is <c>swf:typeFilter.name</c> .</li>
    /// <li> <c>typeFilter.version</c> : String constraint. The key is <c>swf:typeFilter.version</c> .</li>
    /// 
    /// </ul>
    /// </li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
    /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
    /// .</para>
    /// </summary>
    public partial class CountOpenWorkflowExecutionsRequest : AmazonWebServiceRequest
    {
        private string domain;
        private ExecutionTimeFilter startTimeFilter;
        private WorkflowTypeFilter typeFilter;
        private TagFilter tagFilter;
        private WorkflowExecutionFilter executionFilter;

        /// <summary>
        /// The name of the domain containing the workflow executions to count.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;
        }

        /// <summary>
        /// Specifies the start time criteria that workflow executions must meet in order to be counted.
        ///  
        /// </summary>
        public ExecutionTimeFilter StartTimeFilter
        {
            get { return this.startTimeFilter; }
            set { this.startTimeFilter = value; }
        }

        // Check to see if StartTimeFilter property is set
        internal bool IsSetStartTimeFilter()
        {
            return this.startTimeFilter != null;
        }

        /// <summary>
        /// Specifies the type of the workflow executions to be counted. <note><c>executionFilter</c>, <c>typeFilter</c> and <c>tagFilter</c> are
        /// mutually exclusive. You can specify at most one of these in a request.</note>
        ///  
        /// </summary>
        public WorkflowTypeFilter TypeFilter
        {
            get { return this.typeFilter; }
            set { this.typeFilter = value; }
        }

        // Check to see if TypeFilter property is set
        internal bool IsSetTypeFilter()
        {
            return this.typeFilter != null;
        }

        /// <summary>
        /// If specified, only executions that have a tag that matches the filter are counted. <note><c>executionFilter</c>, <c>typeFilter</c> and
        /// <c>tagFilter</c> are mutually exclusive. You can specify at most one of these in a request.</note>
        ///  
        /// </summary>
        public TagFilter TagFilter
        {
            get { return this.tagFilter; }
            set { this.tagFilter = value; }
        }

        // Check to see if TagFilter property is set
        internal bool IsSetTagFilter()
        {
            return this.tagFilter != null;
        }

        /// <summary>
        /// If specified, only workflow executions matching the <c>WorkflowId</c> in the filter are counted. <note><c>executionFilter</c>,
        /// <c>typeFilter</c> and <c>tagFilter</c> are mutually exclusive. You can specify at most one of these in a request.</note>
        ///  
        /// </summary>
        public WorkflowExecutionFilter ExecutionFilter
        {
            get { return this.executionFilter; }
            set { this.executionFilter = value; }
        }

        // Check to see if ExecutionFilter property is set
        internal bool IsSetExecutionFilter()
        {
            return this.executionFilter != null;
        }

    }
}
    
