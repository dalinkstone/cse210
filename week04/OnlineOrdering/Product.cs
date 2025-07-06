public class Product
{
    private int _id;
    private string _name;
    private int _price;
    private int _quantity;

    public Product(int id, string name, int price, int quantity) 
    {
	_id = id;
	_name = name;
	_price = price;
	_quantity = quantity;
    }

    public string GetProductName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _id;
    }

    public int GetProductPrice()
    {
        return _price;
    }

    public int GetProductQuantity()
    {
        return _quantity;
    }

    public int TotalCost(int price, int quantity)
    {
        return price * quantity;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {GetProductId()} - {GetProductName()}");
    }
}
