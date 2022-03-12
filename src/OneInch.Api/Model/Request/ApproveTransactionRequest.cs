
using System.Collections.Generic;
using System;

namespace OneInch.Api
{   
    [OneInchRoute("approve/transaction")]
    public class ApproveTransactionRequest : OneInchRequestBase
    {
        [OneInchParameter("tokenAddress")]
        public string TokenAddress {get;set;}

        [OneInchParameter("amount")]
        public string Amount {get;set;}

    }
}