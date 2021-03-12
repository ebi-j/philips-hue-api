namespace PhilipsHue.Api.Domain
{
    public class Control
    {
        public int MinDimLevel { get; private set; }
        public int MaxLumen { get; private set; }
        public string ColorGamutType { get; private set; }
        public double[][] ColorGamut { get; private set; }
        public ColorTemperatureControl ColorTemperatureControl { get; private set; }

        public Control(
            int minDimLevel,
            int maxLumen,
            string colorGamutType,
            double[][] colorGamut,
            ColorTemperatureControl colorTemperatureControl)
        {
            MinDimLevel = minDimLevel;
            MaxLumen = maxLumen;
            ColorGamutType = colorGamutType;
            ColorGamut = colorGamut;
            ColorTemperatureControl = colorTemperatureControl;
        }
    }
}
