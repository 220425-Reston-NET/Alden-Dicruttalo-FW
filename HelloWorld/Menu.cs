
public class Menu
{
    public void shop()
    {
        bool repeat = true;
        int total = 0;
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
        string answer = Console.ReadLine();
            if(answer == "0")
            {
                repeat = false;
            }
            if(answer == "1")
            {
                Console.WriteLine("Beef is $3");
                total += 3;
                Console.WriteLine("Your current total is: $"+ total);
                Console.WriteLine("");
            }
            if(answer == "2")
            {
                Console.WriteLine("Chicken is $4");
                total += 4;
                Console.WriteLine("Your current total is: $"+ total);
                Console.WriteLine("");
            }
            if(answer == "3")
            {
                Console.WriteLine("Milk is $5");
                total += 5;
                Console.WriteLine("Your current total is: $"+ total);
                Console.WriteLine("");
            }
            if(answer == "4")
            {
                Console.WriteLine("Eggs are $6");
                total += 6;
                Console.WriteLine("Your current total is: $"+ total);
                Console.WriteLine("");
            }
            if(answer == "5")
            {
                Console.WriteLine("Juice is $7");
                total += 7;
                Console.WriteLine("Your current total is: $"+ total);
                Console.WriteLine("");
            }
            if(answer == "6")
            {
                Console.WriteLine("Thank you for Shopping.");
                Console.WriteLine("Your total is: $"+ total);
                repeat = false;
                
            }

        }
    }


    
}
