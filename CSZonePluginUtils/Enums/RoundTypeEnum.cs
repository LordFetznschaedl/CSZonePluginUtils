﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CSZonePluginUtils.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RoundTypeEnum
    {
        Undefined = -1,
        Pistol = 0,
        Mid = 1,
        FullBuy = 2,
    }
}
