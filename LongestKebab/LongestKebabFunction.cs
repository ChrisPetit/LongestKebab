using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace LongestKebab
{
    public static class LongestKebabFunction
    {
        [FunctionName("CalculateLongestKebab")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string kilosGroundLamb = req.Query["kilosGroundLamb"];

            var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            kilosGroundLamb ??= data?.kilosGroundLamb;
            var meat = Convert.ToDouble(kilosGroundLamb);
            var recipe = new Recipe(meat);

            var responseMessage = string.IsNullOrEmpty(kilosGroundLamb)
                ? "This HTTP triggered function executed successfully. " +
                  "Pass the amount of ground lamb in kilo's the query string or in the request body for a personalized recipe."
                : recipe.CreateRecipeMessage();

            return new OkObjectResult(responseMessage);
        }
    }
}
