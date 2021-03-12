namespace PhilipsHue.Api.Domain
{
    public struct ColorTemperatureControl
    {
        public int Min { get; private set; }
        public int Max { get; private set; }

        public ColorTemperatureControl(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }
}
