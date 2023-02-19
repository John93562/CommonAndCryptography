namespace Common.NetStandard.StaticResources
{
    public static class ExtensionClass
    {
        public static string FilterString(this string s)
        {
            return s
                    .ToUpper()
                    .Trim()
                    .Replace('ά', 'α')
                    .Replace('έ', 'ε')
                    .Replace('ώ', 'ω')
                    .Replace('ύ', 'υ')
                    .Replace('ή', 'η')
                    .Replace('ί', 'ι')
                    .Replace('ς', 'σ')
                    .Replace('ό', 'ο')
                    .ToLower();
        }
    }
}
