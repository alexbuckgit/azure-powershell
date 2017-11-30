﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;
using Xunit.Abstractions;

namespace Commands.Network.Test.ScenarioTests
{
    public class SecureGatewayTests : Microsoft.WindowsAzure.Commands.Test.Utilities.Common.RMTestBase
    {
        public SecureGatewayTests(ITestOutputHelper output)
        {
            XunitTracingInterceptor.AddToContext(new XunitTracingInterceptor(output));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSecureGatewayCRUD()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-SecureGatewayCRUD");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSecureGatewayApplicationRuleCollectionCRUD()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-SecureGateway-ApplicationRuleCollectionCRUD");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSecureGatewayNetworkRuleCollectionCRUD()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-SecureGateway-NetworkRuleCollectionCRUD");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSecureGatewayApplicationRuleActionCRUD()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-SecureGateway-ApplicationRuleActionCRUD");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSecureGatewayNetworkRuleActionCRUD()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-SecureGateway-NetworkRuleActionCRUD");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSecureGatewayApplicationRuleProtocolCRUD()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-SecureGateway-ApplicationRuleProtocolCRUD");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSecureGatewayMultiValuedRules()
        {
            NetworkResourcesController.NewInstance.RunPsTest("Test-SecureGateway-MultiValuedRules");
        }
    }
}
