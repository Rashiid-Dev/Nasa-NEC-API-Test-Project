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

        class FirstCometTests : NearEarthCometTests
        {
            [Test]
            public void CheckObjectNameOfFirstComet()
            {
                Assert.AreEqual("P/2004 R1 (McNaught)", (string)nearEarthCometsService.GetFirstComet()[_objectName]);
            }

            [Test]
            public void CheckReferenceOfFirstComet()
            {
                StringAssert.IsMatch("20", (string)nearEarthCometsService.GetFirstComet()[_reference]);
            }

            [Test]
            public void CheckJulianDateOfFirstComet()
            {
                Assert.AreEqual("2455248.548", (string)nearEarthCometsService.GetFirstComet()[_julianDate]);
            }

            [Test]
            public void CheckJulianDateEpochOfFirstComet()
            {
                Assert.AreEqual("54629", (string)nearEarthCometsService.GetFirstComet()[_julianDateEpoch]);
            }

            [Test]
            public void CheckOrbitalPeriodOfFirstComet()
            {
                StringAssert.IsMatch("5.48", (string)nearEarthCometsService.GetFirstComet()[_orbitalPeriod]);
            }

            [Test]
            public void CheckPeriphelionOfFirstComet()
            {
                StringAssert.IsMatch("0.986192006", (string)nearEarthCometsService.GetFirstComet()[_periphelion]);
            }

            [Test]
            public void CheckAphelionOfFirstComet()
            {
                StringAssert.IsMatch("5.23", (string)nearEarthCometsService.GetFirstComet()[_aphelion]);
            }

            [Test]
            public void CheckEccentricityOfFirstComet()
            {
                StringAssert.IsMatch("0.682526943", (string)nearEarthCometsService.GetFirstComet()[_eccentricity]);
            }

            [Test]
            public void CheckOrbitalInclinationOfFirstComet()
            {
                StringAssert.IsMatch("4.894555854", (string)nearEarthCometsService.GetFirstComet()[_orbitalInclination]);
            }

            [Test]
            public void CheckArgumentOfPeriphelionOfFirstComet()
            {
                StringAssert.IsMatch("0.626837835", (string)nearEarthCometsService.GetFirstComet()[_argumentOfPeriphelion]);
            }

            [Test]
            public void CheckLongitudeOfTheAscendingNodeOfFirstComet()
            {
                StringAssert.IsMatch("295.9854497", (string)nearEarthCometsService.GetFirstComet()[_longitudeOfTheAscendingNode]);
            }
        }

       class SecondCometTests : NearEarthCometTests
        {
            [Test]
            public void CheckObjectNameOfSecondComet()
            {
                Assert.AreEqual("P/2008 S1 (Catalina-McNaught)", (string)nearEarthCometsService.GetSecondComet()[_objectName]);
            }
        }

        
    }

}
