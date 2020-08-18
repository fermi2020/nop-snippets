using AddressClick.Core.Extentions;
using System.Collections.Generic;

namespace AddressClick.Core.Responses
{
    public class ResponseFactory
    {
        public static IResponse Success(string message = "Request process successfully.")
        {
            return new Response
            {
                Status = Status.Success,
                Messages = message.ToEnumerable()
            };
        }

        public static IResponse<T> Success<T>(T data, string message = "Request process successfully.")
        {
            return new Response<T>
            {
                Status = Status.Success,
                Messages = message.ToEnumerable(),
                Data = data
            };
        }

        public static IResponse BadRequest(params string[] messages)
        {
            return new Response
            {
                Status = Status.BadRequest,
                Messages = messages
            };
        }

        public static IResponse BadRequest(IEnumerable<string> messages)
        {
            return new Response
            {
                Status = Status.BadRequest,
                Messages = messages
            };
        }

        public static IResponse BadRequest<T>(IEnumerable<string> messages)
        {
            return new Response<T>
            {
                Status = Status.BadRequest,
                Messages = messages,
                Data = default
            };
        }

        public static IResponse BadRequest<T>(params string[] messages)
        {
            return new Response<T>
            {
                Status = Status.BadRequest,
                Messages = messages,
                Data = default
            };
        }

        public static IResponse NotFound(string message)
        {
            return new Response
            {
                Status = Status.NotFound,
                Messages = message.ToEnumerable()
            };
        }

        public static IResponse<T> NotFound<T>(string message)
        {
            return new Response<T>
            {
                Status = Status.NotFound,
                Messages = message.ToEnumerable(),
                Data = default
            };
        }

        public static IResponse<T> NotFound<T>(T data, string message = "Not Found")
        {
            return new Response<T>
            {
                Status = Status.NotFound,
                Messages = message.ToEnumerable(),
                Data = data
            };
        }


        public static IResponse Unauthorized(string message = "Unauthorized access.")
        {
            return new Response
            {
                Status = Status.Unauthorized,
                Messages = message.ToEnumerable()
            };
        }

        public static IResponse<T> Unauthorized<T>(string message = "Unauthorized access.")
        {
            return new Response<T>
            {
                Status = Status.Unauthorized,
                Messages = message.ToEnumerable(),
                Data = default
            };
        }

        public static IResponse<T> Unauthorized<T>(T data, string message = "Unauthorized access.")
        {
            return new Response<T>
            {
                Status = Status.Unauthorized,
                Messages = message.ToEnumerable(),
                Data = data
            };
        }
    }
}
