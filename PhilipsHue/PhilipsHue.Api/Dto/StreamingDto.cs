using PhilipsHue.Api.Domain;
using System.Runtime.Serialization;

namespace PhilipsHue.Api.Dto
{
    [DataContract(Name = "streaming")]
    public class StreamingDto
    {
        [DataMember(Name = "renderer")]
        public bool Renderer { get; set; }
        [DataMember(Name = "proxy")]
        public bool Proxy { get; set; }

        public Streaming ToStreaming()
        {
            return new Streaming(Renderer, Proxy);
        }
    }
}

