
using System.Threading.Tasks;
using System.Text.Json;

namespace OneInch.Api
{
    /// <summary> 
    /// Client that manages requests with the "Token" service.
    /// </summary>
    /// <remarks>Gets data for supported tokens.</remarks>    
    /// <see href="https://docs.1inch.io/api/tokens">Token documentation</see>  
    public class LiquiditySourcesClient : ILiquiditySourcesClient
    {
        IApiAdapter _api;
        public LiquiditySourcesClient(IApiAdapter apiAdapter)
        {          
            Guard.ArgumentsAreNotNull(apiAdapter);
              
            _api = apiAdapter;
        }

        /// <summary>
        /// Get array of all supported liquidity providers.
        /// </summary>
        /// <returns>List response containing liquidity provider data array.</returns>
        public async Task<ProtocolsResponseDto> GetAll()
        {
            var response = await _api.SendRequest(Paths.API.LiquiditySources); 
            return JsonSerializer.Deserialize<ProtocolsResponseDto>(response);
        }
    }

}