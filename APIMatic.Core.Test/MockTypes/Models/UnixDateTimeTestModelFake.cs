﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Test.MockTypes.Convertors;
using Newtonsoft.Json;

namespace APIMatic.Core.Test.MockTypes.Models
{
    internal class UnixDateTimeTestModelFake
    {
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("dateTime")]
        public int DateTime { get; set; }
    }
}
