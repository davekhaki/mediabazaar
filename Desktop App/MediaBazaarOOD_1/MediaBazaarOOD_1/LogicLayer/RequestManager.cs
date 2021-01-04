using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBazaarOOD_1.DataLayer;
using MediaBazaarOOD_1.Class;

namespace MediaBazaarOOD_1.LogicLayer
{
    public class RequestManager
    {
        Request request = new Request();

        public bool Request(Requests addRequests) {

            request.AddRequest(addRequests);

            return true;
        }

        public bool LoadRequest()
        {

            request.LoadRequests();

            return true;
        }


    }
}
