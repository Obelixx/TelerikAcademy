namespace Cosmetics.Products
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Text;

    abstract public class Product : IProduct
    {
        private const int MinProductName = 3;
        private const int MaxProductName = 10;
        private const string ProductNameString = "Product name";
        private const int MinBrandName = 2;
        private const int MaxBrandName = 10;
        private const string BrandNameString = "Product brand";

        private string name;
        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(
                    value,
                    MaxProductName,
                    MinProductName,
                    string.Format(GlobalErrorMessages.InvalidStringLength, ProductNameString, MinProductName, MaxProductName));
                this.name = value;
            }
        }

        private string brand;
        public string Brand
        {
            get { return brand; }
            private set 
            {
                Validator.CheckIfStringLengthIsValid(
                    value,
                    MaxBrandName,
                    MinBrandName,
                    string.Format(GlobalErrorMessages.InvalidStringLength, BrandNameString, MinBrandName, MaxBrandName));
                brand = value; 
            }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            private set 
            {
                Validator.CheckIfNull(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, Price.GetType().Name));
                price = value; 
            }
        }

        private GenderType gender;
        public GenderType Gender
        {
            get { return gender; }
            private set 
            {
                Validator.CheckIfNull(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, Gender.GetType().Name));
                gender = value; 
            }
        }

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Print()
        {
            return this.ToString();
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            sb.AppendLine(string.Format("  * Price: ${0}", this.Price));
            sb.AppendLine(string.Format("  * For gender: {0}", this.Gender));
            return sb.ToString();
        }
    }
}
