public class Customer
{
    private string _name;
    private Address _address = new Address();

    public class Customer(string name, Address address)
    {
        _name = name;
	_address = address;
   }

    public bool IsCustomerUSA(Address address)
    {
        if (address.IsUSA == true)
        {
            return True;
        }

        return False;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address;
    }

    public void Display()
    {
        Console.WriteLine($"Customer Name: {GetName()}");
    }

}
