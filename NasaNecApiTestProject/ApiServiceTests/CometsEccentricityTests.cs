using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NasaNecApiTestProject.NECService;
using NUnit.Framework;

namespace NasaNecApiTestProject.ApiServiceTests
{
    class CometsEccentricityTests
    {
        private QueryCometsService queryCometsService = new QueryCometsService();

        private string _julianDate = "tp_tdb";
        private string _periphelion = "q_au_1";
        private string _aphelion = "q_au_2";
        private string _orbitalPeriod = "p_yr";
        private string _eccentricity = "e";
        private string _orbitalInclination = "i_deg";
        private string _argumentOfPeriphelion = "w_deg";
        private string _julianDateEpoch = "epoch_tdb";
        private string _longitudeOfTheAscendingNode = "node_deg";
        private string _reference = "ref";
        private string _objectName = "object_name";

        [Test]
        public void CheckCometEccentricity()
        {
            StringAssert.IsMatch("0.682526943", (string)queryCometsService.GetComet(0)[_eccentricity]);
        }

        [Test]
        public void CheckCometEccentricityIsGreaterThanSeven()
        {
            Assert.AreEqual(true, (int)queryCometsService.GetComet(0)[_eccentricity] > 0.07);
        }
    }
}
