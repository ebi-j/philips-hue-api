using PhilipsHue.Api.Domain;
using System.Runtime.Serialization;

namespace PhilipsHue.Api.Dto
{
    [DataContract(Name = "control")]
    public class ControlDto
    {
        [DataMember(Name = "mindimlevel")]
        public int MinDimLevel { get; set; }
        [DataMember(Name = "maxlumen")]
        public int MaxLumen { get; set; }
        [DataMember(Name = "colorgamuttype")]
        public string ColorGamutType { get; set; }
        [DataMember(Name = "colorgamut")]
        public double[][] ColorGamut { get; set; }
        [DataMember(Name = "ct")]
        public CtDto Ct { get; set; }

        public Control ToControl()
        {
            return new Control(
                MinDimLevel,
                MaxLumen,
                ColorGamutType,
                ColorGamut,
                new ColorTemperatureControl(Ct.Min, Ct.Max)
            );
        }
    }
}
