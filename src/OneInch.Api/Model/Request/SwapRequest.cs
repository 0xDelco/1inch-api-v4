
using System.Collections.Generic;
using System;

namespace OneInch.Api
{   
    [OneInchRoute("swap")]
    public class SwapRequest : OneInchRequestBase
    {
        public SwapRequest()
        {
            Protocols = new List<string>();
            ConnectorTokens = new List<string>();
        }

        [OneInchParameter("fromTokenAddress")]
        public string FromTokenAddress {get;set;}

        [OneInchParameter("toTokenAddress")]
        public string ToTokenAddress {get;set;}

        [OneInchParameter("amount")]
        public long Amount {get;set;}

        [OneInchParameter("fromAddress")]
        public string FromAddress {get;set;}
        
        [OneInchParameter("slippage")]
        public int Slippage {get;set;}

        [OneInchParameter("protocols")]
        public List<string> Protocols {get;set;}

        [OneInchParameter("destReceiver")]
        public string DestReceiver {get;set;}

        [OneInchParameter("referrerAddress")]
        public string ReferrerAddress {get;set;}

        [OneInchParameter("fee")]
        public int? Fee {get;set;}

        [OneInchParameter("gasPrice")]
        public int? GasPrice {get;set;}

        [OneInchParameter("disableEstimate")]
        public bool? DisableEstimate {get;set;} 

        [OneInchParameter("burnChi")]
        public bool? BurnChi {get;set;}

        [OneInchParameter("allowPartialFill")]
        public bool? AllowPartialFill {get;set;}

        [OneInchParameter("mainRouteParts")]
        public int? MainRouteParts {get;set;}

        [OneInchParameter("virtualParts")]
        public int? VirtualParts {get;set;}

        [OneInchParameter("parts")]
        public int? Parts {get;set;}

        [OneInchParameter("connectorTokens")]
        public List<string> ConnectorTokens {get;set;} 
        
        [OneInchParameter("complexityLevel")]
        public int? ComplexityLevel {get;set;} 

        [OneInchParameter("gasLimit")]
        public int? GasLimit {get;set;}                  

    }
}