﻿using Adapter.Models.Requests;

namespace Adapter.ThirdPartyAPI
{
    public class HipaaClient
    {
        public string GetHipaaResponse(HipaaRequest request)
        {
            return request.ClaimDescription + "//Processed";
        }
    }
}
