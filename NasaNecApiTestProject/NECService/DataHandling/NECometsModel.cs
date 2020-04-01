using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaNecApiTestProject.NECService.DataHandling
{
    class NECometsModel
    {

        public class Rootobject
        {
            public string _object { get; set; }
            public string epoch_tdb { get; set; }
            public string tp_tdb { get; set; }
            public string e { get; set; }
            public string i_deg { get; set; }
            public string w_deg { get; set; }
            public string node_deg { get; set; }
            public string q_au_1 { get; set; }
            public string q_au_2 { get; set; }
            public string p_yr { get; set; }
            public string moid_au { get; set; }
            public string _ref { get; set; }
            public string object_name { get; set; }
        }

    }
}
