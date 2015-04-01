namespace Extensions.Extensions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    // Todo: Problem 1. StringBuilder.Substring
    //Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

    public static class StringBuilderExtensions
    {
        //using definition in: https://msdn.microsoft.com/en-us/library/aka44szs%28v=vs.110%29.aspx
        public static StringBuilder Substring(this StringBuilder sb, int index, int length = int.MaxValue)
        {
            if (index + length > sb.Length)
            {
                throw new ArgumentOutOfRangeException("StartIndex plus length indicates a position not within this instance.");
            }

            if (index < 0 || length < 0)
            {
                throw new ArgumentOutOfRangeException("StartIndex or length is less than zero.");
            }

            var newSb = new StringBuilder();
            for (int i = index; i < index + length && i < sb.Length; i++)
            {
                newSb.Append(sb[i]);
            }
            return (newSb);
        }
    }
}
