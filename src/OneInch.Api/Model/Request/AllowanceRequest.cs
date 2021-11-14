
using System.Collections.Generic;
using System;

namespace OneInch.Api
{   
    [OneInchRoute("approve/allowance")]
    public class AllowanceRequest : OneInchRequestBase
    {
        [OneInchParameter]
        public string tokenAddress {get;set;}

        [OneInchParameter]
        public string walletAddress {get;set;}

    }
}