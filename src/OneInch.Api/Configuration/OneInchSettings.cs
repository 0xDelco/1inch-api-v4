
namespace OneInch.Api
{
    /// <summary>
    /// Model for OneInch API configuration settings.
    /// </summary>
    public class OneInchSettings : IOneInchSettings
    {
        public BlockchainSettings Ethereum {get;set;}

        public BlockchainSettings BinanceSmartChain{get;set;}

        public BlockchainSettings Polygon {get;set;}

        public BlockchainSettings Optimism {get;set;}

        public BlockchainSettings Arbitrum {get;set;}

        public BlockchainSettings Gnosis {get;set;}
    
        public BlockchainSettings Avalanche {get;set;}
        public BlockchainSettings Fantom {get;set;}
    }

}