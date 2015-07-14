namespace _1.ClassChef_CSharp
{
    using System;

    public class Potato : Vegetable
    {
        public Potato()
            : base()
        {
            this.IsRotten = false;
        }

        public bool IsRotten { get; set; }
    }
}
