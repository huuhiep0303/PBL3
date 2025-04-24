using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl.entity_class;
using pbl.Manager.Interface;

namespace pbl.Manager.BLL
{
    internal class RequestManagement : IRequestManagement
    {
        private readonly List<ReturnRequest> returnRequests =new();
        private readonly IInventoryManagement iM;

        public RequestManagement(IInventoryManagement im)
        {
            iM = im;
        }
        public async Task<ReturnRequest> CreateReturnRequestAsync(int orderId,int productId,int quantity, string reason
        , IEnumerable<string> imagePaths)
        {
            var returnRequest = new ReturnRequest(orderId, productId, quantity, reason, imagePaths); 
            returnRequests.Add(returnRequest);
            Console.WriteLine("Đã tạo yêu cầu trả hàng!");
            return await Task.FromResult(returnRequest);
        }
        public async Task<List<ReturnRequest>> GetPendingRequestsAsync()
        {
            var list = returnRequests.Where(r => r.Status == RequestStatus.Pending).ToList();
            return await Task.FromResult(list);
        }
        public async Task<bool> ApproveRequestAsync(int requestId)
        {
            var req = returnRequests.FirstOrDefault(r => r.ReturnId == requestId);
            if (req == null || req.Status != RequestStatus.Pending)
            {
                Console.WriteLine("Lỗi k thấy yêu cầu!");
                return false;
            }
            req.Approve();
            Console.WriteLine("Đã duyệt yêu cầu!");

                
            return await iM.ImportOrReturnStock(req.ProductId,req.Quantity,"RETURN");

        }
        public async Task<bool> RejectRequestAsync(int requestId)
        {
            var req = returnRequests.FirstOrDefault(r => r.ReturnId==requestId);
            if (req == null || req.Status != RequestStatus.Pending)
            {
                Console.WriteLine("Lỗi");
                return false;
            }
            req.Reject();
            Console.WriteLine("Từ chối yêu cầu");
            return await Task.FromResult(true);

        }
        public void DisplayRequest()
        {
            foreach (var req in returnRequests)
            {
                Console.WriteLine(req);
            }
        }
        public void DisplayPendingRequest()
        {
            foreach (var req in returnRequests)
            {
                if (req.Status == RequestStatus.Pending)
                Console.WriteLine(req);
            }
        }
    }
}
