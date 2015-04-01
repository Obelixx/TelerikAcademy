namespace Extensions.Extensions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    // Todo: Problem 2. IEnumerable extensions
    //Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

    public static class IEnumerableExtensions
    {
        //sum, product, min, max, average.
        public static T SumOfList<T>(this IEnumerable<T> list)
        {
            dynamic sum = default(T);
            try
            {
                foreach (var item in list)
                {
                    sum += item;
                }
                return sum;
            }
            catch (NullReferenceException)
            {

                throw new NullReferenceException("List is empty!");
            }
        }

        public static T ProductOfList<T>(this IEnumerable<T> list)
        {
            dynamic product = 1;
            try
            {
                foreach (var item in list)
                {
                    product *= item;
                }
                return product;
            }
            catch (NullReferenceException)
            {

                throw new NullReferenceException("List is empty!");
            }
        }

        public static T MinOfList<T>(this IEnumerable<T> list)
        {
            dynamic min = list.First();
            try
            {
                foreach (var item in list)
                {
                    if (min > item)
                    {
                        min = item;
                    }
                }
                return min;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("List is empty!");
            }
        }

        public static T MaxOfList<T>(this IEnumerable<T> list)
        {
            dynamic max = list.First();
            try
            {
                foreach (var item in list)
                {
                    if (max < item)
                    {
                        max = item;
                    }
                }
                return max;
            }
            catch (NullReferenceException)
            {

                throw new NullReferenceException("List is empty!");
            }
        }

        public static T AverageOfList<T>(this IEnumerable<T> list)
        {
            return (list.SumOfList() / (dynamic)list.Count());
        }

    }
}
