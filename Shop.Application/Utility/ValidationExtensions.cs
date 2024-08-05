using System.Text.RegularExpressions;

namespace Shop.Application.Utility;

public static class ValidationExtensions
{
    public static bool IsValidEmail(this string email)
    {
        const string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
        var regex = new Regex(emailRegex);
        return regex.IsMatch(email);
    }

    public static bool IsValidMobileNumber(this string phoneNumber)
    {
        const string phoneNumberRegex = @"^09\d{9}$";
        var regex = new Regex(phoneNumberRegex);
        return regex.IsMatch(phoneNumber);
    }

}