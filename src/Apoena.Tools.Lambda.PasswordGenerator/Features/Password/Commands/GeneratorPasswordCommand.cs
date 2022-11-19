using Amazon.Lambda.Core;
using Apoena.Tools.PasswordGenerator.Lambda.Wrapper;

namespace Apoena.Tools.PasswordGenerator.Lambda.Features.Password.Commands;
public class GeneratorPasswordCommand
{
    public int NumberOfCharacters { get; set; }
    public bool ContainUppercase { get; set; }
    public bool ContainLowerCase { get; set; }
    public bool ContainNumbers { get; set; }
    public bool ContainSymbols { get; set; }
}

public class GeneratorPasswordCommandHandler
{
    public async Task<Result<string>> Handle(GeneratorPasswordCommand command)
    {
        string patternChars = string.Empty;

        if (command.ContainUppercase)
        {
            LambdaLogger.Log("[X] ContainUppercase");
            patternChars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        if (command.ContainLowerCase)
        {
            LambdaLogger.Log("[X] ContainLowerCase");
            patternChars += "abcdefghijklmnopqrstuvwxyz";
        }

        if (command.ContainNumbers)
        {
            LambdaLogger.Log("[X] ContainNumbers");
            patternChars += "0123456789";
        }

        if (command.ContainSymbols)
        {
            LambdaLogger.Log("[X] ContainSymbols");
            patternChars += "!@#%$^&*";
        }

        var temporaryString = new char[command.NumberOfCharacters];
        var random = new Random();

        for (int i = 0; i < temporaryString.Length; i++)
        {
            temporaryString[i] = patternChars[random.Next(patternChars.Length)];
        }

        var generatedPassword = new string(temporaryString);

        LambdaLogger.Log($"Password: {generatedPassword}");
        return await Result<string>.SuccessAsync(generatedPassword, "Successfully generated password!");
    }

}