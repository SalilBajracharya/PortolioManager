using FluentResults;

namespace PortfolioManager.Api.Common.Errors
{
    public class NotFoundError : Error
    {
        public NotFoundError(string message) : base(message)
        {
            Metadata.Add("HttpStatusCode", 404);
        }
    }
}
