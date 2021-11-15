
using System.Collections.Generic;
using System;

namespace OneInch.Api
{   
    [OneInchRoute("approve/allowance")]
    public class AllowanceRequest : OneInchRequestBase
    {
        [OneInchParameter("tokenAddress")]
        public string TokenAddress {get;set;}

        [OneInchParameter("walletAddress")]
        public string WalletAddress {get;set;}

    }
}