using System.Text.RegularExpressions;

namespace SwissArmy
{
    public class EmailValidator
    {
	    private const string EMAIL_REGULAR_EXPRESSION_VALIDATOR =
	        @"^[_a-zA-Z0-9-]+(\.[_a-zA-Z0-9-]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*\.(([0-9]{1,3})|([a-zA-Z]{2,3})|(aero|coop|info|museum|name|us|es))$";

        public static bool IsValidEmailAddress(string email)
        {
            var regex = new Regex(EMAIL_REGULAR_EXPRESSION_VALIDATOR);
            return regex.IsMatch(email);
        }
    }
}
