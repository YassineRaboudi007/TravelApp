namespace TravelApp.Shared
{
    public class BaseError
    {
        public string code { get; init; }
        public string? description { get; init; }

        public BaseError(string code, string? description)
        {
            this.code = code;
            this.description = description;
        }
    }
}
