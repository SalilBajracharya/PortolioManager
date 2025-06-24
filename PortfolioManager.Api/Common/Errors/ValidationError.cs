using FluentResults;

namespace PortfolioManager.Api.Common.Errors
{
    public class ValidationError : Error
    {
        public ValidationError(string message) : base(message)
        {
            Metadata.Add("HttpStatusCode", "400");
        }
    }
}
