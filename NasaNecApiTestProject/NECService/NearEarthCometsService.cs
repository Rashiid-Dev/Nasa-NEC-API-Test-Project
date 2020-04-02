﻿using System;
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
    class NearEarthCometsService
    {
        public NECometsCallManager neCometsCallManager = new NECometsCallManager();


        public NEComets neComets = new NEComets();


        public String nearEarthComets;


        public JArray json_file;

        public NearEarthCometsService()
        {
            nearEarthComets = neCometsCallManager.GetNearEarthComets();
            neComets.DeserializeInfo(nearEarthComets);
            json_file = JsonConvert.DeserializeObject<JArray>(nearEarthComets);
        }



        public JToken GetComet(int cometno)
        {
            return json_file[cometno];
        }

        //public JToken GetSecondComet()
        //{
        //    return json_file[1];
        //}


    }
}
