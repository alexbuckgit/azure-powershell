//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Remove, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Host", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSOperationStatusResponse))]
    public partial class RemoveAzureRmDedicatedHost : ComputeAutomationBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.Name, VerbsCommon.Remove))
                {
                    string resourceGroupName;
                    string hostGroupName;
                    string hostName;
                    switch (this.ParameterSetName)
                    {
                        case "ResourceIdParameter":
                            resourceGroupName = GetResourceGroupName(this.ResourceId);
                            hostGroupName = GetResourceName(this.ResourceId, "Microsoft.Compute/hostGroups", "hosts");
                            hostName = GetInstanceId(this.ResourceId, "Microsoft.Compute/hostGroups", "hosts");
                            break;
                        case "ObjectParameter":
                            resourceGroupName = GetResourceGroupName(this.InputObject.Id);
                            hostGroupName = GetResourceName(this.InputObject.Id, "Microsoft.Compute/hostGroups", "hosts");
                            hostName = GetInstanceId(this.InputObject.Id, "Microsoft.Compute/hostGroups", "hosts");
                            break;
                        default:
                            resourceGroupName = this.ResourceGroupName;
                            hostGroupName = this.HostGroupName;
                            hostName = this.Name;
                            break;
                    }

                    var result = DedicatedHostsClient.DeleteWithHttpMessagesAsync(resourceGroupName, hostGroupName, hostName).GetAwaiter().GetResult();
                    PSOperationStatusResponse output = new PSOperationStatusResponse
                    {
                        StartTime = this.StartTime,
                        EndTime = DateTime.Now
                    };

                    if (result != null && result.Request != null && result.Request.RequestUri != null)
                    {
                        output.Name = GetOperationIdFromUrlString(result.Request.RequestUri.ToString());
                    }

                    WriteObject(output);
                }
            });
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string HostGroupName { get; set; }

        [Alias("HostName")]
        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 2,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceNameCompleter("Microsoft.Compute/dedicatedHosts", "ResourceGroupName")]
        public string Name { get; set; }

        [Parameter(
            ParameterSetName = "ResourceIdParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string ResourceId { get; set; }

        [Alias("Host")]
        [Parameter(
            ParameterSetName = "ObjectParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public PSHost InputObject { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }
    }
}
