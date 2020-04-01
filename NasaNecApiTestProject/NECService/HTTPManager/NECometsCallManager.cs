using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace NasaNecApiTestProject.NECService.HTTPManager
{
    class NECometsCallManager
    {
        private readonly IRestClient client;

        public NECometsCallManager()
        {
            client = new RestClient(AppConfigReader.BaseUrl);
        }

        public string GetNearEarthComets()
        {
            var request = new RestRequest(AppConfigReader.Resource);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
