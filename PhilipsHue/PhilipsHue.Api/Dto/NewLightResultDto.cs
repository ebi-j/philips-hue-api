using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PhilipsHue.Api.Dto
{
    [DataContract(Name = "newlights")]
    public class NewLightResultDto
    {
        public Dictionary<string, NewLightDto> NewLights { get; set; }
        [DataMember(Name = "lastscan")]
        public DateTime LastScan { get; set; }
    }
}
