public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    private int ShippingCost(Customer customer)
    {
        if (customer.IsCustomerUSA() == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public int TotalPrice(List<Product> products, int shippingCost)
    {
        int price = 0;
        foreach (Product product in products)
        {
            price += product.TotalCost(product.GetProductPrice(), product.GetProductQuantity()) + ShippingCost(_customer);
        }

        return price;
    }

    public string GetPackagingLabel(List<Product> products)
    {
        string packagingLabel = "";
        foreach (Product product in products)
        {
            packagingLabel += $"ID: {product.GetProductId()}: {product.GetProductName()}\n";
        }

        return packagingLabel;
    }

    public string GetShippingLabel(Customer customer)
    {
        return $"Customer Name: {customer.GetName()}\n Customer Address: {customer.GetAddress()}";
    }

    public void Display()
    {
	Console.WriteLine(GetShippingLabel());
	Console.WriteLine(GetPackagingLabel());
	Console.WriteLine($"Total Price: ${TotalPrice(_products, ShippingCost())}\n");
    }
}
