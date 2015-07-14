namespace _1.ClassChef_CSharp
{
    using System;
    using System.Collections.Generic;

    public class Bowl
    {
        private List<Vegetable> contents;

        public Bowl()
        {
            this.contents = new List<Vegetable>();
        }

        public void Add(Vegetable vegetable)
        {
            if (vegetable.Peel)
            {
                throw new ArgumentException("This vegetable is not peeled.");
            }

            if (vegetable.Whole)
            {
                throw new ArgumentException("Cut veggies into pieces first.");
            }

            this.contents.Add(vegetable);
        }
    }
}
