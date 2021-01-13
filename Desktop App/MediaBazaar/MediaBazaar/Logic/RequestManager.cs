using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBazaar.Data;
using MediaBazaarOO.Entities;

namespace MediaBazaar.Logic
{
    public class RequestManager
    {
        private List<Request> requests = new List<Request>();
        public RequestManager()
        {
            requests = RequestData.GetAllRequests();
        }


        public List<Request> GetRequests()
        {
            return this.requests;
        }

        public void CompleteRequest(int requestId)
        {
            foreach (var request in requests.Where(request => request.Id == requestId))
            {
                request.Status = "Done";
                RequestData.CompleteRequest(requestId);
            }
        }
    }
}
