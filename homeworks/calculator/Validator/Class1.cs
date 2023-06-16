using System.Text.RegularExpressions;

namespace Validator;

public class Class1
{

    public void validate(string input)
    {
        bool onlyCharacters = Regex.IsMatch(input, @"[a-zA-Z]");
        bool noOperation = Regex.IsMatch(input, @"^.{0,2}$");
        if (input == null) throw new ArgumentNullException("input");
        if (onlyCharacters) throw new ArgumentException("The input is not valid, you need to pass digits and characters like (+,-,/ or *)");
        if (noOperation) throw new ArgumentException("The input is not an operation");
    }
}
