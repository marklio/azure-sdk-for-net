// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    public partial class WordPressInstanceResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version.Value.ToString());
            }
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName");
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(DatabaseUser))
            {
                writer.WritePropertyName("databaseUser");
                writer.WriteStringValue(DatabaseUser);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WordPressInstanceResourceData DeserializeWordPressInstanceResourceData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<WordPressVersion> version = default;
            Optional<string> databaseName = default;
            Optional<string> databaseUser = default;
            Optional<Uri> siteUrl = default;
            Optional<ApplicationProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("version"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            version = new WordPressVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("databaseName"))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databaseUser"))
                        {
                            databaseUser = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("siteUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                siteUrl = null;
                                continue;
                            }
                            siteUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ApplicationProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WordPressInstanceResourceData(id, name, type, systemData, Optional.ToNullable(version), databaseName.Value, databaseUser.Value, siteUrl.Value, Optional.ToNullable(provisioningState));
        }
    }
}
