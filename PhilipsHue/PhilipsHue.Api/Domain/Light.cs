namespace PhilipsHue.Api.Domain
{
    public class Light
    {
        public int Id { get; private set; }
        public LightState LightState { get; private set; }
        public Software Software { get; private set; }
        public string Type { get; private set; }
        public string Name { get; private set; }
        public string ModelId { get; private set; }
        public string ManufactureName { get; private set; }
        public string ProductName { get; private set; }
        public Capabilities Capabilities { get; private set; }
        public Config Config { get; private set; }
        public string UniqueId { get; private set; }

        public Light(
            int id,
            LightState lightState,
            Software software,
            string type,
            string name,
            string modelId,
            string manufactureName,
            string productName,
            Capabilities capabilities,
            Config config,
            string uniqueId)
        {
            Id = id;
            LightState = lightState;
            Software = software;
            Type = type;
            Name = name;
            ModelId = modelId;
            ManufactureName = manufactureName;
            ProductName = productName;
            Capabilities = capabilities;
            Config = config;
            UniqueId = uniqueId;
        }
    }
}
