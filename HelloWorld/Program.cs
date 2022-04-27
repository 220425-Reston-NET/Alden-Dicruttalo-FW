// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");

//[Class name] [NameofObject] = new [Class name]();

Car carObj1 = new Car();


int mile = carObj1.TotalDistancePerFuel();

carObj1.Sum(5,10);

Console.WriteLine("End of method");
string owner = "Chadel";

Car carObj2 = new Car(owner);
Console.WriteLine(carObj2.Owner);
carObj2.Owner = "Maaz";
Console.WriteLine(carObj2.Owner);

carObj2.Fuel = -100;
Console.WriteLine(carObj2.Fuel);

// Menu groceryMenu = new Menu();
// groceryMenu.Shop();


//Menu Demo
Menu2 menuObj = new Menu2();
bool repeat = true;
Console.WriteLine("Hello! What is your name?");
menuObj.Name = Console.ReadLine();
while(repeat)
{
    menuObj.GreetUser();
    string answer = Console.ReadLine();
    if(answer == "1")
    {
        menuObj.BuyItem();
    }
    else if(answer == "2")
    {
        Console.WriteLine("Your total is: $" + menuObj.Total);
        Console.WriteLine("Thank you for shopping with us! :)");
        repeat = false;
    }
}


