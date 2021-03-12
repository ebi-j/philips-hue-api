using PhilipsHue.Api.Domain;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PhilipsHue.Api.Dto
{
    [DataContract(Name = "state")]
    public class LightStateDto
    {
        [DataMember(Name = "on")]
        public bool On { get; set; }
        [DataMember(Name = "bri")]
        public int Brightness { get; set; }
        [DataMember(Name = "hue")]
        public int Hue { get; set; }
        [DataMember(Name = "sat")]
        public int Saturation { get; set; }
        [DataMember(Name = "effect")]
        public string Effect { get; set; }
        [DataMember(Name = "xy")]
        public List<double> CIEColorXy { get; set; }
        [DataMember(Name = "ct")]
        public int ColorTemperature { get; set; }
        [DataMember(Name = "alert")]
        public string Alert { get; set; }
        [DataMember(Name = "colormode")]
        public string ColorMode { get; set; }
        [DataMember(Name = "mode")]
        public string Mode { get; set; }
        [DataMember(Name = "reachable")]
        public bool Reachable { get; set; }

        public LightState ToLightState()
        {
            return new LightState(
                On,
                Brightness,
                Hue,
                Saturation,
                new CIEColor(CIEColorXy[0], CIEColorXy[1]),
                ColorTemperature,
                Enum.Parse<Alert>(Alert, true),
                Enum.Parse<Effect>(Effect, true),
                ColorMode,
                Mode,
                Reachable
            );
        }
    }
}
