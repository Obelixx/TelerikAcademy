namespace Cosmetics.Products
{
    using System.Collections.Generic;

    using Cosmetics.Contracts;

    class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> cart = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            cart.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            cart.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return cart.Contains(product);
        }

        public decimal TotalPrice()
        {
            decimal total = 0;
            foreach (var prod in cart)
	        {
	        	 total += prod.Price;
	        }
            return total;
        }
    }
}
