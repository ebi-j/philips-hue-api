using System.Runtime.Serialization;

namespace PhilipsHue.Api.Dto
{
    [DataContract(Name = "ct")]
    public class CtDto
    {
        [DataMember(Name = "min")]
        public int Min { get; set; }
        [DataMember(Name = "max")]
        public int Max { get; set; }
    }
}
