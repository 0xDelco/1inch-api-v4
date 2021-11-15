
using System.Collections.Generic;
using System;

namespace OneInch.Api
{   
    [OneInchRoute("quote")]
    public class QuoteRequest : OneInchRequestBase
    {
        public QuoteRequest()
        {
            ConnectorTokens = new List<string>();
            Protocols = new List<string>();
        }

        /// <summary>
        /// Contract token address being sold.
        /// </summary>
        /// <value></value>
        [OneInchParameter("fromTokenAddress")]
        public string FromTokenAddress {get;set;}
        
        /// <summary>
        /// Contract token address being bought.
        /// </summary>
        /// <value></value>
        [OneInchParameter("toTokenAddress")]
        public string ToTokenAddress {get;set;}
        
        /// <summary>
        /// Amount of a token to sell, set in minimal divisible units.
        /// </summary>
        /// <value></value>
        [OneInchParameter("amount")]
        public long Amount {get;set;}

        /// <summary>
        /// Token connectors to assist exchange with routing if a pool with default connectors cannot be found.
        /// </summary>
        /// <value></value>
        [OneInchParameter("connectorTokens")]
        public List<string> ConnectorTokens {get;set;}
        
        /// <summary>
        /// Allowable fee percentage limit (min: 0; max: 3; default: 0;).
        /// </summary>
        /// <value></value>
        [OneInchParameter("fee")]
        public int Fee {get;set;}
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [OneInchParameter("gasPrice")]
        public int GasPrice {get;set;}
        
        /// <summary>
        /// List of liquidity protocol names to use. If not set, all liquidity protocols will be used.
        /// </summary>
        /// <value></value>
        [OneInchParameter("protocols")]
        public List<string> Protocols {get;set;}
        
        /// <summary>
        /// Maximum number of token-connectors to be used in a transaction.
        /// </summary>
        /// <value></value>
        [OneInchParameter("complexityLevel")]
        public int ComplexityLevel {get;set;}
        
        /// <summary>
        /// Limit maximum number of main route parts.
        /// </summary>
        /// <value></value>
        [OneInchParameter("mainRouteParts")]
        public int MainRouteParts {get;set;}

        /// <summary>
        /// Limit maximum number of route parts.
        /// </summary>
        /// <value></value>
        [OneInchParameter("parts")]
        public int Parts {get;set;}
        
        /// <summary>
        /// Maximum amount of gas for a swap.
        /// </summary>
        /// <value></value>
        [OneInchParameter("gasLimit")]
        public int GasLimit {get;set;}


        /// <summary>
        /// Limit maximum number of virtual parts.
        /// </summary>
        /// <value></value>
        [OneInchParameter("virtualParts")]
        public int VirtualParts {get;set;}

        /// <summary>
        /// Extracts addresses from Token objects and adds them to the connectorTokens list.
        /// </summary>
        /// <param name="tokens"></param>
        public void AddConnectorTokens(List<Token> tokens)
        {
            tokens.ForEach(x => {
                this.ConnectorTokens.Add(x.address);
            });
        }

        /// <summary>       
        /// Extracts address from Token object and adds it to the connectorTokens list.
        /// </summary>
        /// <param name="tokens"></param>
        public void AddConnectorToken(Token token)
        {
            this.ConnectorTokens.Add(token.address);
        }

        /// <summary>
        /// Clears connectorToken list.
        /// </summary>
        public void ClearConnectorTokens()
        {
            this.ConnectorTokens.Clear();
        }

        /// <summary>
        /// Sets toToken address from provided token.
        /// </summary>
        /// <param name="token"></param>
        public void SetToToken(Token token)
        {
            this.ToTokenAddress = token.address;
        }

        /// <summary>
        /// Sets fromToken address from provided token.
        /// </summary>
        /// <param name="token"></param>
        public void SetFromToken(Token token)
        {
            this.FromTokenAddress = token.address;
        }
    }
}