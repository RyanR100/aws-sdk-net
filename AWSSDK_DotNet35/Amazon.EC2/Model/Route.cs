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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a route in a route table.</para>
    /// </summary>
    public class Route
    {
        
        private string destinationCidrBlock;
        private string gatewayId;
        private string instanceId;
        private string instanceOwnerId;
        private string networkInterfaceId;
        private RouteState state;


        /// <summary>
        /// The CIDR block used for the destination match.
        ///  
        /// </summary>
        public string DestinationCidrBlock
        {
            get { return this.destinationCidrBlock; }
            set { this.destinationCidrBlock = value; }
        }

        // Check to see if DestinationCidrBlock property is set
        internal bool IsSetDestinationCidrBlock()
        {
            return this.destinationCidrBlock != null;
        }

        /// <summary>
        /// The ID of a gateway attached to your VPC.
        ///  
        /// </summary>
        public string GatewayId
        {
            get { return this.gatewayId; }
            set { this.gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this.gatewayId != null;
        }

        /// <summary>
        /// The ID of a NAT instance in your VPC.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The AWS account ID of the owner of the instance.
        ///  
        /// </summary>
        public string InstanceOwnerId
        {
            get { return this.instanceOwnerId; }
            set { this.instanceOwnerId = value; }
        }

        // Check to see if InstanceOwnerId property is set
        internal bool IsSetInstanceOwnerId()
        {
            return this.instanceOwnerId != null;
        }

        /// <summary>
        /// The ID of the network interface.
        ///  
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceId; }
            set { this.networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this.networkInterfaceId != null;
        }

        /// <summary>
        /// The state of the route. The <c>blackhole</c> state indicates that the route's target isn't available (for example, the specified gateway
        /// isn't attached to the VPC, or the specified NAT instance has been terminated).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>active, blackhole</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public RouteState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }
    }
}
