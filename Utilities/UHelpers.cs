using System.Globalization;

namespace DeltaSchool.Utilities
{
    public static class UHelpers
    {
        public static string ToTitleCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(input.Trim().ToLower());
        }

        public static string GetValueOrtNull(string input) => string.IsNullOrWhiteSpace(input) ? null : input.Trim();
    }
}
