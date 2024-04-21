using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra6_APP.Services
{
    public static class WebAPIConnection
    {
        public static string ProductionURLPrefix = "http://192.168.0.2:45455/api/";

        public static string TestingURLPrefix = "http://192.168.0.2:45455/api/";

        public static string ApiKeyName = "P6ApiKey";

        public static string ApiKeyValue = "autosmagnate";
    }
}
