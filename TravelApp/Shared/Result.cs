namespace TravelApp.Shared
{
    public class Result<TValue, TError>
    {
        public readonly TValue? Value;
        public readonly List<TError>? Errors;
        public bool IsSuccess { get; }

        private Result(TValue value)
        {
            IsSuccess = true;
            Value = value;
            Errors = default;
        }

        private Result(List<TError> error)
        {
            IsSuccess = false;
            Value = default;
            Errors = error;
        }

        private Result(TError error)
        {
            IsSuccess = false;
            Value = default;
            Errors = new List<TError> { error };
        }

        public static implicit operator Result<TValue, TError>(TValue value) => new Result<TValue, TError>(value);

        public static implicit operator Result<TValue, TError>(TError error) => new Result<TValue, TError>(error);

        public static implicit operator Result<TValue, TError>(List<TError> error) => new Result<TValue, TError>(error);

        public static Result<TValue, TError> Failure(List<TError> errors)
        {
            return new Result<TValue, TError>(errors);
        }
    }
}
