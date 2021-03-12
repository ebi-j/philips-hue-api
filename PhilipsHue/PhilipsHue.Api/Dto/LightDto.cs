using PhilipsHue.Api.Domain;
using System.Runtime.Serialization;

namespace PhilipsHue.Api.Dto
{
    [DataContract(Name = "light")]
    public class LightDto
    {
        [DataMember(Name = "state")]
        public LightStateDto State { get; set; }
        [DataMember(Name = "swupdate")]
        public SoftwareUpdateDto SoftwareUpdate { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "modelid")]
        public string ModelId { get; set; }
        [DataMember(Name = "manufacturername")]
        public string ManufacturerName { get; set; }
        [DataMember(Name = "productname")]
        public string ProductName { get; set; }
        [DataMember(Name = "capabilities")]
        public CapabilitiesDto Capabilities { get; set; }
        [DataMember(Name = "config")]
        public ConfigDto Config { get; set; }
        [DataMember(Name = "uniqueid")]
        public string UniqueId { get; set; }
        [DataMember(Name = "swversion")]
        public string SoftwareVersion { get; set; }

        public Light ToLight(int id)
        {
            return new Light(
                id,
                State.ToLightState(),
                new Software(SoftwareUpdate.State, SoftwareVersion, SoftwareUpdate.LastInstall),
                Type,
                Name,
                ModelId,
                ManufacturerName,
                ProductName,
                Capabilities.ToCapabilities(),
                Config.ToConfig(),
                UniqueId
            );
        }
    }
}
