using System.Globalization;
namespace Shopping.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            this.product = product;
        }

        public double Subtotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return product.Price
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity"
                + Quantity
                + ", Subtotal: $"
                + Subtotal().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
