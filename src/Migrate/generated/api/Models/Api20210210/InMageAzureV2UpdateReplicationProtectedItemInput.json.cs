namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMage Azure V2 input to update replication protected item.</summary>
    public partial class InMageAzureV2UpdateReplicationProtectedItemInput
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInput.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInput.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2UpdateReplicationProtectedItemInput FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json ? new InMageAzureV2UpdateReplicationProtectedItemInput(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject into a new instance of <see cref="InMageAzureV2UpdateReplicationProtectedItemInput"
        /// />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal InMageAzureV2UpdateReplicationProtectedItemInput(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __updateReplicationProtectedItemProviderInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.UpdateReplicationProtectedItemProviderInput(json);
            {_recoveryAzureV1ResourceGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryAzureV1ResourceGroupId"), out var __jsonRecoveryAzureV1ResourceGroupId) ? (string)__jsonRecoveryAzureV1ResourceGroupId : (string)RecoveryAzureV1ResourceGroupId;}
            {_recoveryAzureV2ResourceGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryAzureV2ResourceGroupId"), out var __jsonRecoveryAzureV2ResourceGroupId) ? (string)__jsonRecoveryAzureV2ResourceGroupId : (string)RecoveryAzureV2ResourceGroupId;}
            {_useManagedDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("useManagedDisks"), out var __jsonUseManagedDisks) ? (string)__jsonUseManagedDisks : (string)UseManagedDisk;}
            {_targetProximityPlacementGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetProximityPlacementGroupId"), out var __jsonTargetProximityPlacementGroupId) ? (string)__jsonTargetProximityPlacementGroupId : (string)TargetProximityPlacementGroupId;}
            {_targetAvailabilityZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("targetAvailabilityZone"), out var __jsonTargetAvailabilityZone) ? (string)__jsonTargetAvailabilityZone : (string)TargetAvailabilityZone;}
            {_targetVMTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("targetVmTags"), out var __jsonTargetVMTags) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2UpdateReplicationProtectedItemInputTargetVMTags.FromJson(__jsonTargetVMTags) : TargetVMTag;}
            {_targetManagedDiskTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("targetManagedDiskTags"), out var __jsonTargetManagedDiskTags) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2UpdateReplicationProtectedItemInputTargetManagedDiskTags.FromJson(__jsonTargetManagedDiskTags) : TargetManagedDiskTag;}
            {_targetNicTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("targetNicTags"), out var __jsonTargetNicTags) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageAzureV2UpdateReplicationProtectedItemInputTargetNicTags.FromJson(__jsonTargetNicTags) : TargetNicTag;}
            {_sqlServerLicenseType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("sqlServerLicenseType"), out var __jsonSqlServerLicenseType) ? (string)__jsonSqlServerLicenseType : (string)SqlServerLicenseType;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="InMageAzureV2UpdateReplicationProtectedItemInput" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="InMageAzureV2UpdateReplicationProtectedItemInput" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __updateReplicationProtectedItemProviderInput?.ToJson(container, serializationMode);
            AddIf( null != (((object)this._recoveryAzureV1ResourceGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryAzureV1ResourceGroupId.ToString()) : null, "recoveryAzureV1ResourceGroupId" ,container.Add );
            AddIf( null != (((object)this._recoveryAzureV2ResourceGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryAzureV2ResourceGroupId.ToString()) : null, "recoveryAzureV2ResourceGroupId" ,container.Add );
            AddIf( null != (((object)this._useManagedDisk)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._useManagedDisk.ToString()) : null, "useManagedDisks" ,container.Add );
            AddIf( null != (((object)this._targetProximityPlacementGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetProximityPlacementGroupId.ToString()) : null, "targetProximityPlacementGroupId" ,container.Add );
            AddIf( null != (((object)this._targetAvailabilityZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._targetAvailabilityZone.ToString()) : null, "targetAvailabilityZone" ,container.Add );
            AddIf( null != this._targetVMTag ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._targetVMTag.ToJson(null,serializationMode) : null, "targetVmTags" ,container.Add );
            AddIf( null != this._targetManagedDiskTag ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._targetManagedDiskTag.ToJson(null,serializationMode) : null, "targetManagedDiskTags" ,container.Add );
            AddIf( null != this._targetNicTag ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._targetNicTag.ToJson(null,serializationMode) : null, "targetNicTags" ,container.Add );
            AddIf( null != (((object)this._sqlServerLicenseType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._sqlServerLicenseType.ToString()) : null, "sqlServerLicenseType" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}