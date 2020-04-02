using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NasaNecApiTestProject.NECService.DataHandling;
using NasaNecApiTestProject.NECService.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NasaNecApiTestProject.NECService
{
    class SpecificCometService
    {
        public NECometsCallManager neCometsCallManager = new NECometsCallManager();


        public NEComets neComets = new NEComets();


        public String nearEarthComets;


        public JArray json_file;

        public SpecificCometService()
        {
            nearEarthComets = neCometsCallManager.Get5DBrorsenComet();
            neComets.DeserializeInfo(nearEarthComets);
            json_file = JsonConvert.DeserializeObject<JArray>(nearEarthComets);
        }

        public JToken GetComet()
        {
            return json_file[0];
        }

    }
}
