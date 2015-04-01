
namespace _2.Students_and_workers.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students_and_workers.Models;

    static class HumanExtensions
    {
        public static List<Human> SortedByfirstNameAndLastName(this List<Human> humans)
        {
            return (
                (from human in humans
                 orderby human.FirstName, human.LastName
                 select human
                ).ToList()
                );
        }
    }
}
