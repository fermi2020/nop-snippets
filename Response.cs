using System.Collections.Generic;

namespace AddressClick.Core.Responses
{
    internal class Response : IResponse
    {
        public Status Status { get; internal set; }

        public IEnumerable<string> Messages { get; internal set; }
    }

    internal class Response<T> : Response, IResponse<T>
    {
        public T Data { get; internal set; }
    }
}
