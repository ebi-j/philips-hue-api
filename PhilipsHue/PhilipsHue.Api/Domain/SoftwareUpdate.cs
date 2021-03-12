using System;

namespace PhilipsHue.Api.Domain
{
    public struct Software
    {
        public string State { get; private set; }
        public string Version { get; private set; }
        public DateTime LastInstall { get; private set; }

        public Software(string state, string version, DateTime lastInstall)
        {
            State = state;
            Version = version;
            LastInstall = lastInstall;
        }
    }
}
