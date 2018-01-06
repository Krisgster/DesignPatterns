using System;
using System.Runtime.InteropServices;

namespace Patterns.Singleton
{
    /// <summary>
    /// http://www.oodesign.com/singleton-pattern.html
    /// </summary>
    public class GlobalConfig
    {
        public int MaxNumberOfPhotos { get; private set; }
        public string PhotoDomainName { get; private set; }
        public string CreatedTime { get; private set; }

        private static GlobalConfig _configs;
        private GlobalConfig()
        {
            //Load config from database
            MaxNumberOfPhotos = 1985;

            //Load config from database
            PhotoDomainName = "Kris";

            CreatedTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }
        public static GlobalConfig GetInstance()
        {
            if (_configs == null)
                _configs = new GlobalConfig();
            return _configs;
        }
    }
}
