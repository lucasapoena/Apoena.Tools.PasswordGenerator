namespace Apoena.Tools.PasswordGenerator.Domain.Entities
{
    public class Password
    {
        const string CHARS_UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string CHARS_LOWER_CASE = "abcdefghijklmnopqrstuvwxyz";
        const string CHARS_NUMBERS = "0123456789";
        const string CHARS_SYMBOLS = "!@#%$^&*";

        public Password(int numberOfCharacters, bool containUppercase, bool containLowerCase, bool containNumbers, bool containSymbols)
        {
            NumberOfCharacters = numberOfCharacters;
            ContainUppercase = containUppercase;
            ContainLowerCase = containLowerCase;
            ContainNumbers = containNumbers;
            ContainSymbols = containSymbols;            
        }

        public int NumberOfCharacters { get; private set; }
        public bool ContainUppercase { get; private set; }
        public bool ContainLowerCase { get; private set; }
        public bool ContainNumbers { get; private set; }
        public bool ContainSymbols { get; private set; }

        public string generatePassword()
        {
            string patternChars = string.Empty;

            if (ContainUppercase)
            {                
                patternChars += CHARS_UPPER_CASE;
            }

            if (ContainLowerCase)
            {                
                patternChars += CHARS_LOWER_CASE;
            }

            if (ContainNumbers)
            {                
                patternChars += CHARS_NUMBERS;
            }

            if (ContainSymbols)
            {
                patternChars += CHARS_SYMBOLS;
            }

            var temporaryString = new char[NumberOfCharacters];
            var random = new Random();

            for (int i = 0; i < temporaryString.Length; i++)
            {
                temporaryString[i] = patternChars[random.Next(patternChars.Length)];
            }

            var generatedPassword = new string(temporaryString);

            return generatedPassword;
        }
    }
}
