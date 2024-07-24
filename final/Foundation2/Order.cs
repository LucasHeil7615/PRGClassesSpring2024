using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem
{
    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.products = new List<Product>();
            this.customer = customer;
        }

        // Adds a product to the order
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // Calculates the total cost of the order including shipping
        public decimal TotalCost()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.TotalCost();
            }
            total += customer.IsInUSA() ? 5 : 35;
            return total;
        }

        // Creates a packing label listing all products
        public string PackingLabel()
        {
            StringBuilder label = new StringBuilder();
            foreach (var product in products)
            {
                label.AppendLine($"{product.Name} ({product.ProductId})");
            }
            return label.ToString();
        }

        // Creates a shipping label with customer details
        public string ShippingLabel()
        {
            return $"{customer.Name}\n{customer.Address}";
        }
    }
}
