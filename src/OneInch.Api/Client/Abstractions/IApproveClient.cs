using System.Threading.Tasks;

namespace OneInch.Api
{
    public interface IApproveClient
    {
        Task<ApproveCallDataResponseDto> GetTransactionApproval(ApproveTransactionRequest request);
        Task<ApproveSpenderResponseDto> GetApprovedSpender();
        Task<TokenAllowance> GetAllowance(AllowanceRequest request);
    }
}