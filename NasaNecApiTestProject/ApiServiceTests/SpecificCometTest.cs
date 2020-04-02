using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NasaNecApiTestProject.NECService;
using NUnit.Framework;

namespace NasaNecApiTestProject.ApiServiceTests
{
    class SpecificCometTest
    {
        private SpecificCometService specificCometService = new SpecificCometService();

        [TestCase("object_name", "5D/Brorsen")]
        public void Check5DBorsenObjectName(string key, string expectedresult)
        {
            var Brorsen = (string)specificCometService.GetComet(0)[key];
            StringAssert.IsMatch(expectedresult, Brorsen );
        }

    }
}
