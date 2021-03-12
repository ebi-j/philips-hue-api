using PhilipsHue.Api.Domain;
using System.Runtime.Serialization;

namespace PhilipsHue.Api.Dto
{
    public class CapabilitiesDto
    {
        [DataMember(Name = "certified")]
        public bool Certified { get; set; }
        [DataMember(Name = "control")]
        public ControlDto Control { get; set; }
        [DataMember(Name = "streaming")]
        public StreamingDto Streaming { get; set; }

        public Capabilities ToCapabilities()
        {
            return new Capabilities(Certified, Control.ToControl(), Streaming.ToStreaming());
        }
    }
}
