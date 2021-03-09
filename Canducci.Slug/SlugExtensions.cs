using System.Globalization;
using System.Text;

namespace Canducci.Slug
{
  public static class SlugExtensions
  {
    public static string ToSlug(this string phrase)
    {
      return GenerateSlug(phrase);
    }
    private static string GenerateSlug(string phrase)
    {
      string str = RemoveAccent(phrase);
      str = System.Text.RegularExpressions.Regex.Replace(str, @"[^a-z0-9\s-]", "");
      str = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", " ").Trim();
      str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
      str = System.Text.RegularExpressions.Regex.Replace(str, @"\s", "-");
      return str;
    }

    private static string RemoveAccent(string text)
    {
      StringBuilder sbReturn = new StringBuilder();
      var arrayText = text
        .ToLower()
        .Normalize(NormalizationForm.FormD)
        .ToCharArray();
      foreach (char letter in arrayText)
      {
        if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
        {
          sbReturn.Append(letter);
        }
      }
      return sbReturn.ToString();
    }
  }
}
