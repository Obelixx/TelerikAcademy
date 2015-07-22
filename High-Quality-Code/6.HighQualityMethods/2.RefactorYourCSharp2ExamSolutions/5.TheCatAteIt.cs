namespace Task5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TheCatAteIt
    {
        public static void Task5Main()
        {
            ////            5
            //// 1 is before 2
            //// 4 is after 2
            //// 3 is before 4
            //// 6 is after 4
            //// 6 is before 8
            int n = int.Parse(Console.ReadLine());

            var conditions = new List<Tuple<int, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] tempString = Console.ReadLine().Split(' ');
                switch (tempString[2])
                {
                    case "before":
                        conditions.Add(new Tuple<int, int>(int.Parse(tempString[0]), int.Parse(tempString[3])));
                        break;
                    case "after":
                        conditions.Add(new Tuple<int, int>(int.Parse(tempString[3]), int.Parse(tempString[0])));
                        break;
                    default:
                        break;
                }
            }

            conditions = conditions.Distinct().ToList();
            var list1 = new List<Tuple<int, int>>();

            // find min  - add to new - remove from old
            while (conditions.Count > 0)
            {
                int mini = 0;
                for (int i = 0; i < conditions.Count; i++)
                {
                    if (conditions[mini].Item1 < conditions[i].Item1)
                    {
                        mini = i;
                    }
                }

                list1.Add(conditions[mini]);
                conditions.RemoveAt(mini);
            }

            foreach (var item in list1)
            {
                Console.Write("{0}{1}", item.Item1, item.Item2);
            }
        }
    }
}
