using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace config_test
{
    public class DataExchange
    {
        private static DataExchange _instance;
        private static readonly object _lock = new object();
        public string roomtemperature = "NoData";
        public string weather = "NoData";
        public readonly string deskpiIP = "";
        public readonly int deskpiSendPort = -1;
        public readonly int deskpiListenPort = -1;
        public readonly string deskpiTrigger = "";
        public readonly string UrlForecast = "";
        public readonly string UrlWeather = "";

        // Private constructor to prevent external instantiation
        private DataExchange()
        {
        }

        // Public property to access the single instance
        public static DataExchange instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DataExchange();
                    }
                    return _instance;
                }
            }
        }
    }
}
