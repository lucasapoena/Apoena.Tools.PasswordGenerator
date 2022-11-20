using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Apoena.Tools.PasswordGenerator.Lambda.Features.Password.Commands;
using Apoena.Tools.PasswordGenerator.Shared.Wrapper;
using System.Net;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Apoena.Tools.PasswordGenerator.Lambda
{
    public class Function
    {

        /// <summary>
        /// A simple function that takes some parameters and generates a new password
        /// </summary>
        /// <param name="command"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task<APIGatewayProxyResponse> FunctionHandler(APIGatewayProxyRequest request, ILambdaContext context)
        {
            LambdaLogger.Log("Start lambda...");
            var command = new GeneratorPasswordCommand()
            {
                ContainLowerCase= true,
                ContainNumbers= true,
                ContainSymbols= true,
                ContainUppercase= true,
                NumberOfCharacters = 10
            };
            // TODO: Validar como que passa o Handler pelo service locator.
            var handler = new GeneratorPasswordCommandHandler();
            var result = await handler.Handle(command);
            var response = new APIGatewayProxyResponse()
            {
                StatusCode = (int) HttpStatusCode.OK,
                Body = result.Data,
                Headers = new Dictionary<string, string>() {
                    { "Content-Type", "application/json" },
                    { "Accept", "application/json" },   
                }
            };
            LambdaLogger.Log("Stop lambda...");
            return response;
        }
    }
}