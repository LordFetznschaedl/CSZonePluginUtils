using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSZoneNet.Plugin.Utils.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum KevlarEnum
    {
        [EnumMember(Value = "")]
        None = 0,

        [EnumMember(Value = "item_kevlar")]
        Kevlar = 1,

        [EnumMember(Value = "item_assaultsuit")]
        KevlarHelmet = 2,
    }
}
