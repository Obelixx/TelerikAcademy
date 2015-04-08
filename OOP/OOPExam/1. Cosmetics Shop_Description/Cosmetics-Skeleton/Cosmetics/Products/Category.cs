namespace Cosmetics.Products
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Text;

    public class Category : ICategory
    {
        private const int MinCategoryName = 2;
        private const int MaxCategoryName = 15;
        private const string CategoryNotExistEx = "Product {0} does not exist in category {1}!";
        private const string CategoryNameString = "Category name";

        private List<IProduct> products = new List<IProduct>();

        private string name;
        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(
                    value,
                    MaxCategoryName,
                    MinCategoryName,
                    string.Format(GlobalErrorMessages.InvalidStringLength, CategoryNameString, MinCategoryName, MaxCategoryName));
                this.name = value;
            }
        }

        public Category(string name)
        {
            this.Name = name;
        }


        public void AddCosmetics(IProduct cosmetics)
        {
            products.Add(cosmetics);
            products = products.OrderBy(c => c.Brand).ThenByDescending(c => c.Price).ToList();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!products.Remove(cosmetics))
            {
                throw new InvalidOperationException(string.Format(CategoryNotExistEx, cosmetics.Name, this.Name));
            }
        }

        public string Print()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("{0} category - {1} ", this.Name, products.Count));
            if (products.Count == 1)
            {
                sb.Append("product");
            }
            else
            {
                sb.Append("products");
            }
            sb.AppendLine(" in total");
            foreach (var prod in products)
            {
                sb.Append(prod.ToString());
            }
            return sb.ToString().Trim();
        }

    }
}
