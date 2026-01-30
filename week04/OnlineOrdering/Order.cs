using System.Collections.Generic;
using System.Text;

namespace OrderingSystem
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        // constructor
        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        // getters and setters
        public List<Product> GetProducts()
        {
            return _products;
        }

        public Customer GetCustomer()
        {
            return _customer;
        }

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double CalculateTotalCost()
        {
            double totalCost = 0;

            foreach (Product product in _products)
            {
                totalCost += product.GetTotalCost();
            }

            if (_customer.LivesInUSA())
            {
                totalCost += 5;
            }
            else
            {
                totalCost += 35;
            }

            return totalCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder label = new StringBuilder();
            label.AppendLine("PACKING LABEL:");
            label.AppendLine("==============");

            foreach (Product product in _products)
            {
                label.AppendLine($"Product: {product.GetName()} (ID: {product.GetProductId()})");
            }

            return label.ToString();
        }

        public string GetShippingLabel()
        {
            StringBuilder label = new StringBuilder();
            label.AppendLine("SHIPPING LABEL:");
            label.AppendLine("===============");
            label.AppendLine($"Customer: {_customer.GetName()}");
            label.AppendLine(_customer.GetAddress().GetFullAddress());

            return label.ToString();
        }
    }
}