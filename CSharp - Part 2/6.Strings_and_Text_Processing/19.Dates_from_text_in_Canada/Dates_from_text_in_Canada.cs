//Problem 19. Dates from text in Canada

//    Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//    Display them in the standard date format for Canada.

namespace _19.Dates_from_text_in_Canada
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Dates_from_text_in_Canada
    {
        static DateTime PrsDate(string date)
        {
            string[] dates = date.Split('.');
            int[] intDates = new int[dates.Length];

            for (int i = 0; i < dates.Length; i++)
            {
                intDates[i] = int.Parse(dates[i]);
            }
            DateTime DT = new DateTime(intDates[2], intDates[1], intDates[0]);
            return (DT);
        }

        static string DatesFromText(string input)
        {
            var words = new List<string>();
            var tmpWords = input.Split(' ');
            words.AddRange(tmpWords);

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i][words[i].Length - 1] == '.')
                {
                    words[i] = words[i].Remove(words[i].Length - 1);
                }
            }

            var dt = new List<DateTime>();
            for (int i = 0; i < words.Count; i++)
            {
                DateTime tempDT = new DateTime();
                try
                {
                    tempDT = PrsDate(words[i]);
                }
                catch (Exception)
                {
                    continue;
                }

                dt.Add(tempDT);
            }

            //build string
            StringBuilder sb = new StringBuilder();

            var culture = new System.Globalization.CultureInfo("en-Ca");
            //var Day = culture.DateTimeFormat.GetDayName(dtAfter);

            for (int i = 0; i < dt.Count; i++)
            {
                sb.Append(dt[i].ToString(culture.DateTimeFormat.ShortDatePattern,culture));
                sb.Append("\n");
            }
            return (sb.ToString());

        }
        static void Main()
        {
            string inputText =
                @"asdasdasda
sdasdasd
asd 12.10.2003 asdasd
asdas 10.12.2004";
            string output = DatesFromText(inputText);
            Console.WriteLine(output);

        }
    }
}/////// no more time :(
