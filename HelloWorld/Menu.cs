
public class Menu
{
    public void shop()
    {
        bool repeat = true;
        int total = 0;
        string selection = "";
        Console.Clear();
        Console.WriteLine("Welcome to our Store!");
        while(repeat)
        {
        Console.WriteLine("Press the crrosponding number to select an item");
        Console.WriteLine("Press 0 to exit");
        Console.WriteLine("1 Beef");
        Console.WriteLine("2 Chicken");
        Console.WriteLine("3 Milk");
        Console.WriteLine("4 Eggs");
        Console.WriteLine("5 Juice");
        Console.WriteLine("Press 6 to Checkout");
        Console.WriteLine("");
        selection = Console.ReadLine();
            if(selection == "0")
            {
                repeat = false;
            }
            if(selection == "1")
            {
                Console.WriteLine("Beef is $3");
                total += 3;
                Console.WriteLine("Your current total is: $"+ total);
                Console.WriteLine("");
            }
            if(selection == "2")
            {
                Console.WriteLine("Chicken is $4");
                total += 4;
                Console.WriteLine("Your current total is: $"+ total);
                Console.WriteLine("");
            }
            if(selection == "3")
            {
                Console.WriteLine("Milk is $5");
                total += 5;
                Console.WriteLine("Your current total is: $"+ total);
                Console.WriteLine("");
            }
            if(selection == "4")
            {
                Console.WriteLine("Eggs are $6");
                total += 6;
                Console.WriteLine("Your current total is: $"+ total);
                Console.WriteLine("");
            }
            if(selection == "5")
            {
                Console.WriteLine("Juice is $7");
                total += 7;
                Console.WriteLine("Your current total is: $"+ total);
                Console.WriteLine("");
            }
            if(selection == "6")
            {
                Console.WriteLine("Thank you for Shopping.");
                Console.WriteLine("Your total is: $"+ total);
                repeat = false;
                
            }

        }
    }


    
}
