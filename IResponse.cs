using System.Collections.Generic;

namespace AddressClick.Core.Responses
{
    public interface IResponse
    {
        Status Status { get; }

        IEnumerable<string> Messages { get; }
    }

    public interface IResponse<out T> : IResponse
    {
        T Data { get; }
    }
}
