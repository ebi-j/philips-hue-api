using PhilipsHue.Api.Domain;
using System.Runtime.Serialization;

namespace PhilipsHue.Api.Dto
{
    [DataContract(Name = "config")]
    public class ConfigDto
    {
        [DataMember(Name = "archetype")]
        public string Archetype { get; set; }
        [DataMember(Name = "function")]
        public string Function { get; set; }
        [DataMember(Name = "direction")]
        public string Direction { get; set; }

        public Config ToConfig()
        {
            return new Config(Archetype, Function, Direction);
        }
    }
}
