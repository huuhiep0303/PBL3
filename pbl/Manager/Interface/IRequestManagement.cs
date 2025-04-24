using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl.entity_class;

namespace pbl.Manager.Interface
{
    internal interface IRequestManagement
    {
        Task<ReturnRequest> CreateReturnRequestAsync(
        int orderId,
        int productId,
        int quantity,
        string reason,
        IEnumerable<string> imagePaths
    );
        Task<List<ReturnRequest>> GetPendingRequestsAsync();
        Task<bool> ApproveRequestAsync(int requestId);
        Task<bool> RejectRequestAsync(int requestId);
        void DisplayRequest();
        void DisplayPendingRequest();
    }
}
