using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NasaNecApiTestProject.NECService.DataHandling
{
    class NEComets
    { 


        public NECometsModel deser { get; set; }

        public void DeserializeInfo(string DeserResponse)
        {
            deser = JsonConvert.DeserializeObject<NECometsModel>(DeserResponse);
        }
    }
}
