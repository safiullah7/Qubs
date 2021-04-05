
using System.Net;

namespace Qubs.Models
{
    public class Response<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Content { get; set; }
        public bool HasData { get; set; }
        public string ErrorMessage { get; set; }
    }
}
