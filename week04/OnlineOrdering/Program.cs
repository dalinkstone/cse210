using System;

class Program
{
    static void Main(string[] args)
    {

	Address davidAddress = new Address("123 Main St", "Summer Town", "California", "USA");
	Address darlaAddress = new Address("987 Random Rd", "Winter Ville", "Tokyo", "JP");

	Product shoes = new Product(1, "Shoes", 10, 10);
	Product bike = new Product(2, "Bike", 100, 1);
	Product headphones = new Product(3, "Headphones", 50, 5);

	List<Product> products = new List<Product>
	{
		shoes,
		bike,
		headphones,
	}

	Customer david = new Customer("David", davidAddress);	
	Customer darla = new Customer("Darla", darlaAddress);

	Order davidOrder = new Order(products, david);
	Order darlaOrder = new Order(products, darla);

	

	davidOrder.Display();
	Console.WriteLine();
	darlaOrder.Display();

    }
}
