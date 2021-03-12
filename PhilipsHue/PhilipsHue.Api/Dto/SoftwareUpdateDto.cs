using System;
using System.Runtime.Serialization;

namespace PhilipsHue.Api.Dto
{
    [DataContract(Name = "swupdate")]
    public class SoftwareUpdateDto
    {
        [DataMember(Name = "state")]
        public string State { get; set; }
        //TODO: Check if this needs to be set as string
        [DataMember(Name = "lastinstall")]
        public DateTime LastInstall { get; set; }
    }
}
