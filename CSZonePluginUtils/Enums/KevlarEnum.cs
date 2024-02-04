using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSZoneNet.Plugin.Utils.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum KevlarEnum
    {
        None = 0,
        Kevlar = 1,
        KevlarHelmet = 2,
    }
}
