namespace GoogleAdsV8Test
{
    #region Includes

    using System.Threading.Tasks;
    using Implementations;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.Extensions.Logging;

    #endregion

    public static class Function1
    {
        #region Public Methods

        [FunctionName("Function1")]
        public static async Task<string> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
            HttpRequest req,
            ILogger log)
        {
            var clientFactory = new GoogleAdsFactory();

            clientFactory.GetClient();

            return "Hello World";
        }

        #endregion
    }
}