namespace Canducci.Slug
{
    /// <summary>
    /// Slug Extensions class String
    /// </summary>
    public static class SlugExtensions
    {
        /// <summary>
        /// ToSlug
        /// </summary>
        /// <param name="phrase">Text</param>
        /// <returns>Text Slug</returns>
        public static string ToSlug(this string phrase)
        {
            return GenerateSlug(phrase, 0);
        }

        /// <summary>
        /// ToSlug
        /// </summary>
        /// <param name="phrase">Test</param>
        /// <param name="length">Length Text</param>
        /// <returns>Test Slug</returns>
        public static string ToSlug(this string phrase, int length)
        {
            return GenerateSlug(phrase, length);
        }

        private static string GenerateSlug(string phrase, int length)
        {
            string str = RemoveAccent(phrase);
            str = System.Text.RegularExpressions.Regex.Replace(str, @"[^a-z0-9\s-]", "");
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", " ").Trim();
            if (length > 0)
            {
                str = str.Substring(0, str.Length <= length ? str.Length : length).Trim();
            }
            return System.Text.RegularExpressions.Regex.Replace(str, @"\s", "-");
        }

        private static string RemoveAccent(string phrase)
        {
            System.Text.StringBuilder str = new System.Text.StringBuilder();
            str.Clear();
            foreach (char letter in phrase.ToLower().Normalize(System.Text.NormalizationForm.FormD).ToCharArray())
            {
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(letter) != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    str.Append(letter);
                }
            }
            return str.ToString();
        }
    }
}
