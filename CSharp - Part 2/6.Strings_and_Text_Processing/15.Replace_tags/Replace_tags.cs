//Problem 15. Replace tags

//    Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

//Example:
//input 	output
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p> 	<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

namespace _15.Replace_tags
{
    using System;

    class Replace_tags
    {
        static void ReplaceTags(ref string input)
        {
            input = input.Replace("<a href=\"", "[URL=");
            input = input.Replace("\">", "]");
            input = input.Replace("</a>", "[/URL]");
        }

        static void Main()
        {
            string input = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            Console.WriteLine("Input is: {0}", input);
            ReplaceTags(ref input);
            Console.WriteLine("Replaced input is: {0}", input);

        }
    }
}
