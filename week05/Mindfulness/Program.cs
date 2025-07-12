using System;

class Program
{
    static void Main(string[] args)
    {

   Console.WriteLine("Menu Options:");
   Console.WriteLine("1. Start Breathing Activity");
   Console.WriteLine("2. Start Reflecting Activity");
   Console.WriteLine("3. Start Listing Activity");
   Console.WriteLine("4. Quit");
   Console.Write("Select a Choice from the menu: ");
   string input = Console.ReadLine();
   
   while (true)
   {
     switch (input)
     {
       case "1":
         BreathingActivity.Run();
         break;
       case "2":
         ReflectingActivity.Run();
         break;
       case "3":
         ListingActivity.Run();
         break;
       case "4":
         break;
     }
   }



    }
}
