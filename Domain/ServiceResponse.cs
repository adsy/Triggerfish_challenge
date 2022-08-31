using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ServiceResponse
    {
        public int StatusCode { get; set; }
        public string ServiceResponseMessage { get; set; }
        public bool IsSuccessful => StatusCode >= 200 || StatusCode <= 299;
    }

    public class ServiceResponse<T> : ServiceResponse
    {
        public T ReturnData { get; set; }
    }
}
