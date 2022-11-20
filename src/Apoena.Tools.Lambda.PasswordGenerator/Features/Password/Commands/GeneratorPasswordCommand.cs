using Amazon.Lambda.Core;
using Apoena.Tools.PasswordGenerator.Shared.Wrapper;

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
        var password = new Domain.Entities.Password(
            command.NumberOfCharacters,
            command.ContainUppercase,
            command.ContainLowerCase,
            command.ContainNumbers,
            command.ContainSymbols
        );

        var passwordGenerated = password.generatePassword();

        LambdaLogger.Log($"Password: {passwordGenerated}");
        return await Result<string>.SuccessAsync(passwordGenerated, "Successfully generated password!");
    }

}