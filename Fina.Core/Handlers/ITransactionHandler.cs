using System.Transactions;
using Fina.Core.Requests.Transactions;
using Fina.Core.Responses;

namespace Fina.Core.Handlers;

public interface ITransactionHandler
{
    Task<Response<Transaction?>> CreateAsync(CreateTrasactionRequest request);
    Task<Response<Transaction?>> UpdateAsync(UpdateTransactionRequest request);
    Task<Response<Transaction?>> DeleteAsync(DeleteTransactionRequest request);
    Task<Response<Transaction?>> GetByIdAsync(GetTransactionByIdRequest request);
    Task<PagedResponses<List<Transaction>?>> GetByPeriodAsync(GetTransactionsByPeriodRequest request);
}