public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
	_address = address;
   }

    public bool IsCustomerUSA(Address address)
    {
        if (address.IsUSA(address.GetCountry()) == true)
        {
            return true;
        }

        return false;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetCustomerAddress()
    {
        return _address;
    }

    public void Display()
    {
        Console.WriteLine($"Customer Name: {GetName()} - Customer Address: {_address.GetAddress()}");
    }

}
