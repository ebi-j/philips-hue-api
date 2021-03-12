using PhilipsHue.Api.Domain;
using System.Runtime.Serialization;

namespace PhilipsHue.Api.Dto
{
    [DataContract(Name = "newlight")]
    public class NewLightDto
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        public NewLight ToNewLight(int id) => new NewLight(id, Name);
    }
}
