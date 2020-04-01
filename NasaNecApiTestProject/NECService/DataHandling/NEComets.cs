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


        public List<Rootobject> deser { get; set; }

        public void DeserializeInfo(string DeserResponse)
        {
            deser = JsonConvert.DeserializeObject<List<Rootobject>>(DeserResponse);
        }
    }
}
