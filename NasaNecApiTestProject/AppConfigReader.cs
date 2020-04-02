using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaNecApiTestProject
{
    public class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string Resource = ConfigurationManager.AppSettings["resource"];
        public static readonly string ObjectName = ConfigurationManager.AppSettings["objectname"];
    }
}
