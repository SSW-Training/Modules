using System.Text.RegularExpressions;

namespace SSW.Training.Business.Tests.Unit
{
    public static class StringValidationExtensions
    {
        public static bool IsValidEmailAddress(this string email)
        {
            Regex regex = new Regex(@"^[\w-]+(?:\.[\w-]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7}$");
            Match match = regex.Match(email);
            return match.Success;
        }
    }
}
