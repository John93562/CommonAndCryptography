namespace Common.NetStandard.Services
{
    //public static class GreeklishService
    //{
    //    static List<(string, string)> allCharactersToReplace = new List<(string, string)>()
    //            {
    //                ("α","a"),
    //                ("ά","a"),
    //                ("β","b"),
    //                ("γ","g"),
    //                ("δ","d"),
    //                ("ε","e"),
    //                ("έ","e"),
    //                 ("ζ","z"),
    //                ("η","h"),
    //                ("ή","h"),
    //                ("θ","th"),
    //                ("ι","i"),
    //                ("ί","i"),
    //                ("κ","k"),
    //                 ("λ","l"),
    //                ("μ","m"),
    //                ("ν","n"),
    //                ("ξ","ks"),
    //                ("ο","o"),
    //                ("ό","o"),
    //                ("π","p"),
    //                 ("ρ","r"),
    //                ("σ","s"),
    //                ("ς","s"),
    //                ("τ","t"),
    //                ("υ","u"),
    //                ("ύ","u"),
    //                ("φ","f"),
    //                ("χ","x"),
    //                 ("ψ","ps"),
    //                ("ω","w"),
    //                ("ώ","w")

    //            };
    //    public static List<string> GreekLettersWithAccents = new List<string>()
    //                {
    //"ά","έ","ή","ί","ό","ύ","ώ","ς"
    //                };


    //    public static string ConvertToGreeklish(this string text)
    //    {

    //        text = text.ToLower();
    //        foreach (  (string greekLetter, string englishLetter)   in allCharactersToReplace)
    //        {
    //            text = text.Replace(greekLetter, englishLetter);
    //        }
    //        return text.ToUpper();

    //    }
    //    public static string ConvertFromGreeklish(this string text)
    //    {

    //        text = text.ToLower();
    //        foreach (  (string greekLetter, string englishLetter)    in allCharactersToReplace)
    //        {
    //            if (GreekLettersWithAccents.Contains(greekLetter))
    //                continue;

    //            text = text.Replace(englishLetter, greekLetter);
    //        }
    //        return text.ToUpper();
    //    }

    //}
}
