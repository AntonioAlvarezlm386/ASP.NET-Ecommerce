using System;
using System.Collections.Generic;

namespace BussinesLayer.Common
{
    public class Result<T>
    {
        public bool isSuccess { get; private set; }
        public T Data { get; private set; }
        public string ErrorMessage { get; private set;}

        public int StatusCode { get; private set; }
        public List<string> ErrorDetails { get; private set; } = new List<string>();
        public Exception InnerException { get; private set; }
        public string Severity { get; private set; }
        public string StackTrace { get; private set; }
        public string ErrorCode { get; private set; }
        public long ExecutionTime { get; private set; }
        public Dictionary<string, object> Metadata { get; private set; }


        //private constructor
        private Result() { }

        public static Result<T> Succes(T data, Dictionary<string, object> metadata = null, long executionTime = 0)
        {
            return new Result<T>
            {
                isSuccess = true,
                Data = data,
                StatusCode = 200,
                ExecutionTime = executionTime,
                Metadata = metadata
            };
        }

        public static Result<T> Failure(string errorMessage, int statusCode = 500, string errorCode = null, string serverity = "Error", Exception ex = null, long executionTime = 0)
        {
            return new Result<T>
            {
                isSuccess = false,
                ErrorMessage = errorMessage,
                StatusCode = statusCode,
                ErrorCode = errorCode,
                Severity = serverity,
                StackTrace = ex?.StackTrace,
                ErrorDetails = ex != null ? new List<string> { ex.Message } : new List<string>(),
                InnerException = ex != null ? ex.InnerException : null,
                ExecutionTime = executionTime
            };
        }
    }
}
