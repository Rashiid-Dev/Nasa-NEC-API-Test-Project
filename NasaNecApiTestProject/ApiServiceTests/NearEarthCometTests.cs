using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NasaNecApiTestProject.NECService;
using NUnit.Framework;

namespace NasaNecApiTestProject.ApiServiceTests
{
    class NearEarthCometTests
    {
        private NearEarthCometsService nearEarthCometsService = new NearEarthCometsService();

        [Test]
        public void CheckObjectNameOfFirstComet()
        {
            Assert.AreEqual("P/2004 R1 (McNaught)", (string)nearEarthCometsService.GetFirstComet()["object_name"]);
        }
    }
}
