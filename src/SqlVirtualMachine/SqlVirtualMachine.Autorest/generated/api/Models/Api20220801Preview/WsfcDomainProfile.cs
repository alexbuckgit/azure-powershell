// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Extensions;

    /// <summary>Active Directory account details to operate Windows Server Failover Cluster.</summary>
    public partial class WsfcDomainProfile :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IWsfcDomainProfile,
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IWsfcDomainProfileInternal
    {

        /// <summary>Backing field for <see cref="ClusterBootstrapAccount" /> property.</summary>
        private string _clusterBootstrapAccount;

        /// <summary>
        /// Account name used for creating cluster (at minimum needs permissions to 'Create Computer Objects' in domain).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string ClusterBootstrapAccount { get => this._clusterBootstrapAccount; set => this._clusterBootstrapAccount = value; }

        /// <summary>Backing field for <see cref="ClusterOperatorAccount" /> property.</summary>
        private string _clusterOperatorAccount;

        /// <summary>
        /// Account name used for operating cluster i.e. will be part of administrators group on all the participating virtual machines
        /// in the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string ClusterOperatorAccount { get => this._clusterOperatorAccount; set => this._clusterOperatorAccount = value; }

        /// <summary>Backing field for <see cref="ClusterSubnetType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.ClusterSubnetType? _clusterSubnetType;

        /// <summary>Cluster subnet type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.ClusterSubnetType? ClusterSubnetType { get => this._clusterSubnetType; set => this._clusterSubnetType = value; }

        /// <summary>Backing field for <see cref="DomainFqdn" /> property.</summary>
        private string _domainFqdn;

        /// <summary>Fully qualified name of the domain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string DomainFqdn { get => this._domainFqdn; set => this._domainFqdn = value; }

        /// <summary>Backing field for <see cref="FileShareWitnessPath" /> property.</summary>
        private string _fileShareWitnessPath;

        /// <summary>Optional path for fileshare witness.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string FileShareWitnessPath { get => this._fileShareWitnessPath; set => this._fileShareWitnessPath = value; }

        /// <summary>Backing field for <see cref="OuPath" /> property.</summary>
        private string _ouPath;

        /// <summary>Organizational Unit path in which the nodes and cluster will be present.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string OuPath { get => this._ouPath; set => this._ouPath = value; }

        /// <summary>Backing field for <see cref="SqlServiceAccount" /> property.</summary>
        private string _sqlServiceAccount;

        /// <summary>
        /// Account name under which SQL service will run on all participating SQL virtual machines in the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string SqlServiceAccount { get => this._sqlServiceAccount; set => this._sqlServiceAccount = value; }

        /// <summary>Backing field for <see cref="StorageAccountPrimaryKey" /> property.</summary>
        private System.Security.SecureString _storageAccountPrimaryKey;

        /// <summary>Primary key of the witness storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public System.Security.SecureString StorageAccountPrimaryKey { get => this._storageAccountPrimaryKey; set => this._storageAccountPrimaryKey = value; }

        /// <summary>Backing field for <see cref="StorageAccountUrl" /> property.</summary>
        private string _storageAccountUrl;

        /// <summary>Fully qualified ARM resource id of the witness storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string StorageAccountUrl { get => this._storageAccountUrl; set => this._storageAccountUrl = value; }

        /// <summary>Creates an new <see cref="WsfcDomainProfile" /> instance.</summary>
        public WsfcDomainProfile()
        {

        }
    }
    /// Active Directory account details to operate Windows Server Failover Cluster.
    public partial interface IWsfcDomainProfile :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Account name used for creating cluster (at minimum needs permissions to 'Create Computer Objects' in domain).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Account name used for creating cluster (at minimum needs permissions to 'Create Computer Objects' in domain).",
        SerializedName = @"clusterBootstrapAccount",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterBootstrapAccount { get; set; }
        /// <summary>
        /// Account name used for operating cluster i.e. will be part of administrators group on all the participating virtual machines
        /// in the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Account name used for operating cluster i.e. will be part of administrators group on all the participating virtual machines in the cluster.",
        SerializedName = @"clusterOperatorAccount",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterOperatorAccount { get; set; }
        /// <summary>Cluster subnet type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Cluster subnet type.",
        SerializedName = @"clusterSubnetType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.ClusterSubnetType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.ClusterSubnetType? ClusterSubnetType { get; set; }
        /// <summary>Fully qualified name of the domain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified name of the domain.",
        SerializedName = @"domainFqdn",
        PossibleTypes = new [] { typeof(string) })]
        string DomainFqdn { get; set; }
        /// <summary>Optional path for fileshare witness.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional path for fileshare witness.",
        SerializedName = @"fileShareWitnessPath",
        PossibleTypes = new [] { typeof(string) })]
        string FileShareWitnessPath { get; set; }
        /// <summary>Organizational Unit path in which the nodes and cluster will be present.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Organizational Unit path in which the nodes and cluster will be present.",
        SerializedName = @"ouPath",
        PossibleTypes = new [] { typeof(string) })]
        string OuPath { get; set; }
        /// <summary>
        /// Account name under which SQL service will run on all participating SQL virtual machines in the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Account name under which SQL service will run on all participating SQL virtual machines in the cluster.",
        SerializedName = @"sqlServiceAccount",
        PossibleTypes = new [] { typeof(string) })]
        string SqlServiceAccount { get; set; }
        /// <summary>Primary key of the witness storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Primary key of the witness storage account.",
        SerializedName = @"storageAccountPrimaryKey",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString StorageAccountPrimaryKey { get; set; }
        /// <summary>Fully qualified ARM resource id of the witness storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified ARM resource id of the witness storage account.",
        SerializedName = @"storageAccountUrl",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountUrl { get; set; }

    }
    /// Active Directory account details to operate Windows Server Failover Cluster.
    internal partial interface IWsfcDomainProfileInternal

    {
        /// <summary>
        /// Account name used for creating cluster (at minimum needs permissions to 'Create Computer Objects' in domain).
        /// </summary>
        string ClusterBootstrapAccount { get; set; }
        /// <summary>
        /// Account name used for operating cluster i.e. will be part of administrators group on all the participating virtual machines
        /// in the cluster.
        /// </summary>
        string ClusterOperatorAccount { get; set; }
        /// <summary>Cluster subnet type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.ClusterSubnetType? ClusterSubnetType { get; set; }
        /// <summary>Fully qualified name of the domain.</summary>
        string DomainFqdn { get; set; }
        /// <summary>Optional path for fileshare witness.</summary>
        string FileShareWitnessPath { get; set; }
        /// <summary>Organizational Unit path in which the nodes and cluster will be present.</summary>
        string OuPath { get; set; }
        /// <summary>
        /// Account name under which SQL service will run on all participating SQL virtual machines in the cluster.
        /// </summary>
        string SqlServiceAccount { get; set; }
        /// <summary>Primary key of the witness storage account.</summary>
        System.Security.SecureString StorageAccountPrimaryKey { get; set; }
        /// <summary>Fully qualified ARM resource id of the witness storage account.</summary>
        string StorageAccountUrl { get; set; }

    }
}