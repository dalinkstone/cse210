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
        if (customer.IsCustomerUSA(_customer.GetCustomerAddress()) == true)
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
            price += product.TotalCost(product.GetProductPrice(), product.GetProductQuantity());
        }

        return price + ShippingCost(_customer);
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
    	return $"Customer Name: {_customer.GetName()} - Customer Address: {_customer.GetCustomerAddress().GetAddress()}";
    }

    public void Display()
    {
	Console.WriteLine(GetShippingLabel(_customer));
	Console.WriteLine(GetPackagingLabel(_products));
	Console.WriteLine($"Total Price: ${TotalPrice(_products, ShippingCost(_customer))}\n");
    }
}
