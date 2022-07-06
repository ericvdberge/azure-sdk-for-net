// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql.Models;

namespace Azure.ResourceManager.MySql
{
    public partial class ServerData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorLogin))
            {
                writer.WritePropertyName("administratorLogin");
                writer.WriteStringValue(AdministratorLogin);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version.Value.ToString());
            }
            if (Optional.IsDefined(SslEnforcement))
            {
                writer.WritePropertyName("sslEnforcement");
                writer.WriteStringValue(SslEnforcement.Value.ToSerialString());
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion");
                writer.WriteStringValue(MinimalTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(InfrastructureEncryption))
            {
                writer.WritePropertyName("infrastructureEncryption");
                writer.WriteStringValue(InfrastructureEncryption.Value.ToString());
            }
            if (Optional.IsDefined(UserVisibleState))
            {
                writer.WritePropertyName("userVisibleState");
                writer.WriteStringValue(UserVisibleState.Value.ToString());
            }
            if (Optional.IsDefined(FullyQualifiedDomainName))
            {
                writer.WritePropertyName("fullyQualifiedDomainName");
                writer.WriteStringValue(FullyQualifiedDomainName);
            }
            if (Optional.IsDefined(EarliestRestoreOn))
            {
                writer.WritePropertyName("earliestRestoreDate");
                writer.WriteStringValue(EarliestRestoreOn.Value, "O");
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile");
                writer.WriteObjectValue(StorageProfile);
            }
            if (Optional.IsDefined(ReplicationRole))
            {
                writer.WritePropertyName("replicationRole");
                writer.WriteStringValue(ReplicationRole);
            }
            if (Optional.IsDefined(MasterServerId))
            {
                writer.WritePropertyName("masterServerId");
                writer.WriteStringValue(MasterServerId);
            }
            if (Optional.IsDefined(ReplicaCapacity))
            {
                writer.WritePropertyName("replicaCapacity");
                writer.WriteNumberValue(ReplicaCapacity.Value);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess");
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServerData DeserializeServerData(JsonElement element)
        {
            Optional<ResourceIdentity> identity = default;
            Optional<MySqlSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> administratorLogin = default;
            Optional<ServerVersion> version = default;
            Optional<SslEnforcementEnum> sslEnforcement = default;
            Optional<MinimalTlsVersionEnum> minimalTlsVersion = default;
            Optional<string> byokEnforcement = default;
            Optional<InfrastructureEncryption> infrastructureEncryption = default;
            Optional<ServerState> userVisibleState = default;
            Optional<string> fullyQualifiedDomainName = default;
            Optional<DateTimeOffset> earliestRestoreDate = default;
            Optional<StorageProfile> storageProfile = default;
            Optional<string> replicationRole = default;
            Optional<string> masterServerId = default;
            Optional<int> replicaCapacity = default;
            Optional<PublicNetworkAccessEnum> publicNetworkAccess = default;
            Optional<IReadOnlyList<ServerPrivateEndpointConnection>> privateEndpointConnections = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = ResourceIdentity.DeserializeResourceIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = MySqlSku.DeserializeMySqlSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("administratorLogin"))
                        {
                            administratorLogin = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            version = new ServerVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sslEnforcement"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sslEnforcement = property0.Value.GetString().ToSslEnforcementEnum();
                            continue;
                        }
                        if (property0.NameEquals("minimalTlsVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            minimalTlsVersion = new MinimalTlsVersionEnum(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("byokEnforcement"))
                        {
                            byokEnforcement = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("infrastructureEncryption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            infrastructureEncryption = new InfrastructureEncryption(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userVisibleState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            userVisibleState = new ServerState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fullyQualifiedDomainName"))
                        {
                            fullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("earliestRestoreDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            earliestRestoreDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("storageProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            storageProfile = StorageProfile.DeserializeStorageProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("replicationRole"))
                        {
                            replicationRole = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("masterServerId"))
                        {
                            masterServerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("replicaCapacity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            replicaCapacity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicNetworkAccess = new PublicNetworkAccessEnum(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ServerPrivateEndpointConnection> array = new List<ServerPrivateEndpointConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServerPrivateEndpointConnection.DeserializeServerPrivateEndpointConnection(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServerData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity.Value, sku.Value, administratorLogin.Value, Optional.ToNullable(version), Optional.ToNullable(sslEnforcement), Optional.ToNullable(minimalTlsVersion), byokEnforcement.Value, Optional.ToNullable(infrastructureEncryption), Optional.ToNullable(userVisibleState), fullyQualifiedDomainName.Value, Optional.ToNullable(earliestRestoreDate), storageProfile.Value, replicationRole.Value, masterServerId.Value, Optional.ToNullable(replicaCapacity), Optional.ToNullable(publicNetworkAccess), Optional.ToList(privateEndpointConnections));
        }
    }
}
