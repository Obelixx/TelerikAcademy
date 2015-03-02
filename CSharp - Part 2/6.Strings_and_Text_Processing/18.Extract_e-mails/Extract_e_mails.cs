//Problem 18. Extract e-mails

//    Write a program for extracting all email addresses from given text.
//    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

namespace _18.Extract_e_mails
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Text;

    class Extract_e_mails
    {
        public static string ExtractEmails(string text) // taken from internet, but with modifications
        {
            //instantiate with this pattern 
            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
                RegexOptions.IgnoreCase);
            //find items that matches with our pattern
            MatchCollection emailMatches = emailRegex.Matches(text);

            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);
            }

            return(sb.ToString());
        }

        static void Main(string[] args)
        {
            string text =
                @"//Problem 18. Extract e-mails

//    Write a program for extracting all email addresses from given text.
//    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
// asd@asd.com 
// asdasd@abv.bg";

            string mails = ExtractEmails(text);
            Console.WriteLine(mails);

        }
    }
}
