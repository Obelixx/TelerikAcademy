namespace Cosmetics.Products
{
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Shampoo : Product, IShampoo, IProduct
    {
        private uint milliliters;
        public uint Milliliters
        {
            get { return this.milliliters; }
            private set
            {
                Validator.CheckIfNull(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, Milliliters.GetType().Name));
                this.milliliters = value;
            }
        }

        private UsageType usage;
        public UsageType Usage
        {
            get { return this.usage; }
            private set
            {
                Validator.CheckIfNull(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, Usage.GetType().Name));
                this.usage = value;
            }
        }
        

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            :base(name,brand,price*milliliters,gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("  * Quantity: "+ this.Milliliters + " ml");
            sb.AppendLine("  * Usage: " + this.Usage);
            return sb.ToString();
        }
    }
}
