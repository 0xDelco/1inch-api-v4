
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OneInch.Api
{
    public interface ILiquiditySourcesClient
    {
        Task<ProtocolsResponseDto>  GetAll();
    }
}