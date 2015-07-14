namespace _2.Refactor
{
    using System;
    using System.Collections.Generic;
    using _1.ClassChef_CSharp;

    /// <summary>
    /// Sample IfProgram class - DONT USE IT!
    /// </summary>
    public class SempleIfProgram
    {
        public static void Main(string[] args)
        {
            Potato potato = new Potato();
            //// ... 
            if (potato != null)
            {
                if (potato.Peel && !potato.IsRotten)
                {
                    var chef = new Chef();
                    chef.Cook(potato);
                }
            }
            //// and
            const int MIN_X = int.MinValue;
            const int MAX_X = int.MaxValue;
            const int MIN_Y = int.MinValue;
            const int MAX_Y = int.MaxValue;

            int x = 0;
            int y = 0;
            bool shouldVisitCell = false;

            if ((x >= MIN_X) && (x <= MAX_X && ((MAX_Y >= y && MIN_Y <= y) && shouldVisitCell)))
            {
                VisitCell();
            }
            ////
        }

        public static bool VisitCell()
        {
            return true;
        }
    }
}
