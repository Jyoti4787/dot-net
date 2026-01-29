namespace PettyCashManager.Infrastructure
{
    // Result<T> represents the outcome of an operation
    // Used to avoid exceptions and safely handle success/failure
    public class Result<T>
    {
        // Indicates whether the operation succeeded
        public bool Success { get; }

        // Message describing success or failure
        public string Message { get; }

        // Data returned from the operation (if any)
        public T Data { get; }

        // Private constructor to control object creation
        private Result(bool success, string message, T data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        // Factory method for successful result
        public static Result<T> Ok(T data, string message = "")
        {
            return new Result<T>(true, message, data);
        }

        // Factory method for failure result
        public static Result<T> Fail(string message)
        {
            return new Result<T>(false, message, default);
        }
    }
}
