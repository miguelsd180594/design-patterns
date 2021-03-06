﻿using Adapter.Models.Requests;
using Adapter.ThirdPartyAPI;

namespace Adapter.Adapters
{
    public class HipaaAdapter : IHipaaAdapter
    {
        private readonly HipaaClient _hipaaClient;
        public HipaaAdapter()
        {
            _hipaaClient = new HipaaClient();
        }
        public string GetHipaaResponse(ClaimRequest request)
        {
            var hipaaRequest = new HipaaRequest { 
                ClaimDescription = string.Concat(
                    request.ClaimStatus,
                    "//",
                    request.Locationid.ToString(),
                    "//",
                    request.ProviderId.ToString())
                };

            return _hipaaClient.GetHipaaResponse(hipaaRequest);
        }
    }
}
