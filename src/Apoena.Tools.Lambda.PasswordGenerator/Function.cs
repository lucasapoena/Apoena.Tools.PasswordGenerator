using Amazon.Lambda.Core;
using Apoena.Tools.PasswordGenerator.Lambda.Features.Password.Commands;
using Apoena.Tools.PasswordGenerator.Lambda.Wrapper;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Apoena.Tools.PasswordGenerator.Lambda;

public class Function
{

    /// <summary>
    /// A simple function that takes some parameters and generates a new password
    /// </summary>
    /// <param name="command"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task<IResult<string>> FunctionHandler(GeneratorPasswordCommand command, ILambdaContext context)
    {
        LambdaLogger.Log("Start lambda...");
        // TODO: Validar como que passa o Handler pelo service locator.
        var handler = new GeneratorPasswordCommandHandler();
        var result = await handler.Handle(command);
        LambdaLogger.Log("Stop lambda...");
        return result;
    }
}
