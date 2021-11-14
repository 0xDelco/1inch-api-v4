
using System.Collections.Generic;
using System;

namespace OneInch.Api
{   
    [OneInchRoute("approve/transaction")]
    public class ApproveTransactionRequest : OneInchRequestBase
    {
        [OneInchParameter]
        public string tokenAddress {get;set;}

        [OneInchParameter]
        public string amount {get;set;}

    }
}