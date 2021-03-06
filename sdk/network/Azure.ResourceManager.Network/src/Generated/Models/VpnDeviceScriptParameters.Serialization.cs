// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnDeviceScriptParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Vendor != null)
            {
                writer.WritePropertyName("vendor");
                writer.WriteStringValue(Vendor);
            }
            if (DeviceFamily != null)
            {
                writer.WritePropertyName("deviceFamily");
                writer.WriteStringValue(DeviceFamily);
            }
            if (FirmwareVersion != null)
            {
                writer.WritePropertyName("firmwareVersion");
                writer.WriteStringValue(FirmwareVersion);
            }
            writer.WriteEndObject();
        }
    }
}
