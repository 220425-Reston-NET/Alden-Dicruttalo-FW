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

Menu groceryMenu = new Menu();

groceryMenu.shop();

