namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;
    

    class Toothpaste : Product, IToothpaste, IProduct
    {
        private List<string> ingredients = new List<string>();

        public string Ingredients
        {
           get { return string.Join(", ",ingredients); }
        }

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ingredients.AddRange(ingredients);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("  * Ingredients: " + Ingredients);
            return sb.ToString();
        }
    }
}
