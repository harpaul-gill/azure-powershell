namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>The recoverable server's properties.</summary>
    public partial class RecoverableServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Edition" /> property.</summary>
        private string _edition;

        /// <summary>Edition of the performance tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Edition { get => this._edition; }

        /// <summary>Backing field for <see cref="HardwareGeneration" /> property.</summary>
        private string _hardwareGeneration;

        /// <summary>Hardware generation associated with the service level objective</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string HardwareGeneration { get => this._hardwareGeneration; }

        /// <summary>Backing field for <see cref="LastAvailableBackupDateTime" /> property.</summary>
        private string _lastAvailableBackupDateTime;

        /// <summary>The last available backup date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string LastAvailableBackupDateTime { get => this._lastAvailableBackupDateTime; }

        /// <summary>Internal Acessors for Edition</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal.Edition { get => this._edition; set { {_edition = value;} } }

        /// <summary>Internal Acessors for HardwareGeneration</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal.HardwareGeneration { get => this._hardwareGeneration; set { {_hardwareGeneration = value;} } }

        /// <summary>Internal Acessors for LastAvailableBackupDateTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal.LastAvailableBackupDateTime { get => this._lastAvailableBackupDateTime; set { {_lastAvailableBackupDateTime = value;} } }

        /// <summary>Internal Acessors for ServiceLevelObjective</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal.ServiceLevelObjective { get => this._serviceLevelObjective; set { {_serviceLevelObjective = value;} } }

        /// <summary>Internal Acessors for VCore</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal.VCore { get => this._vCore; set { {_vCore = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20171201.IRecoverableServerPropertiesInternal.Version { get => this._version; set { {_version = value;} } }

        /// <summary>Backing field for <see cref="ServiceLevelObjective" /> property.</summary>
        private string _serviceLevelObjective;

        /// <summary>The service level objective</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string ServiceLevelObjective { get => this._serviceLevelObjective; }

        /// <summary>Backing field for <see cref="VCore" /> property.</summary>
        private int? _vCore;

        /// <summary>vCore associated with the service level objective</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public int? VCore { get => this._vCore; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The PostgreSQL version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Version { get => this._version; }

        /// <summary>Creates an new <see cref="RecoverableServerProperties" /> instance.</summary>
        public RecoverableServerProperties()
        {

        }
    }
    /// The recoverable server's properties.
    public partial interface IRecoverableServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>Edition of the performance tier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Edition of the performance tier.",
        SerializedName = @"edition",
        PossibleTypes = new [] { typeof(string) })]
        string Edition { get;  }
        /// <summary>Hardware generation associated with the service level objective</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Hardware generation associated with the service level objective",
        SerializedName = @"hardwareGeneration",
        PossibleTypes = new [] { typeof(string) })]
        string HardwareGeneration { get;  }
        /// <summary>The last available backup date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The last available backup date time.",
        SerializedName = @"lastAvailableBackupDateTime",
        PossibleTypes = new [] { typeof(string) })]
        string LastAvailableBackupDateTime { get;  }
        /// <summary>The service level objective</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The service level objective",
        SerializedName = @"serviceLevelObjective",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceLevelObjective { get;  }
        /// <summary>vCore associated with the service level objective</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"vCore associated with the service level objective",
        SerializedName = @"vCore",
        PossibleTypes = new [] { typeof(int) })]
        int? VCore { get;  }
        /// <summary>The PostgreSQL version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The PostgreSQL version",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get;  }

    }
    /// The recoverable server's properties.
    internal partial interface IRecoverableServerPropertiesInternal

    {
        /// <summary>Edition of the performance tier.</summary>
        string Edition { get; set; }
        /// <summary>Hardware generation associated with the service level objective</summary>
        string HardwareGeneration { get; set; }
        /// <summary>The last available backup date time.</summary>
        string LastAvailableBackupDateTime { get; set; }
        /// <summary>The service level objective</summary>
        string ServiceLevelObjective { get; set; }
        /// <summary>vCore associated with the service level objective</summary>
        int? VCore { get; set; }
        /// <summary>The PostgreSQL version</summary>
        string Version { get; set; }

    }
}