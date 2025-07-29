using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public class Order
    {
        private List<Product> products = new List<Product>();
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal GetTotalCost()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.GetTotalCost();
            }

            total += customer.LivesInUSA() ? 5 : 35;

            return total;
        }

        public string GetPackingLabel()
        {
            StringBuilder label = new StringBuilder("Packing Label:\n");
            foreach (var product in products)
            {
                label.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
            }
            return label.ToString();
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
        }
    }
}