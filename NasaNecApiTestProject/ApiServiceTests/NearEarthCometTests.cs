using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NasaNecApiTestProject.NECService;
using NUnit.Framework;

namespace NasaNecApiTestProject.ApiServiceTests
{
    [TestFixture]
    public class NearEarthCometTests
    {
        
        private NearEarthCometsService nearEarthCometsService = new NearEarthCometsService();


        [TestCase("tp_tdb", "2455248.548")]
        [TestCase("epoch_tdb", "54629")]
        [TestCase("p_yr", "5.48")]
        [TestCase("q_au_1", "0.986192006")]
        [TestCase("q_au_2", "5.23")]
        [TestCase("q_au_2", "5.23")]
        [TestCase("i_deg", "4.894555854")]
        [TestCase("w_deg", "0.626837835")]
        [TestCase("node_deg", "295.9854497")]
        public void CheckMcNaughComet(string key, string result)
            {
            var Mcnaught = (string)nearEarthCometsService.GetComet(0)[key];
            StringAssert.IsMatch(Mcnaught, result);
            }


    }

}
