//This is how you create a class by using the class keyword
//public is just there to make the class available for everyone

public class Car
{
    //This is a field
    //It is used to store information or define the current state of the object
    public string _color = "Blue";
    public string _owner = "Stephen";
    public int _fuel = 100;
    public int _gallonPerMile = 5;

    //This is a method
    //A way to represent a behavior/function and it ll run multiple lines of code
    public int TotalDistancePerFuel()
    {
        Console.WriteLine("current Fuel: " + _fuel + " This is the ower: " + _owner);
        Console.WriteLine($"Gallon per Mile: {_gallonPerMile} This is the owner: {_owner}");
        
        Console.WriteLine(_fuel/_gallonPerMile + " This is how many miles");
        //return keyword to give back
        return _fuel/_gallonPerMile;
    }
    //parameters are implemented by adding datatypes inside of the parenthesis
    public void Sum(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }


    // This is a constructor
    // It is a method that will execute whenever you create an object
    public Car()
    {
        _color= "blue";
        _fuel = 100;
        _gallonPerMile = 5;
        _owner = "Stephen";
    }
    public Car(string p_owner)
    {

        _owner = p_owner;
    }
    
    
    
    // public Car()
    // {
    //     Console.WriteLine("Making a car object!");
    // }
    // public Car(string p_color)
    // {
    //     Console.WriteLine("Making a car object!");
    //     _color = p_color;
    // }
    
    // This is a property
    public string Color
    {
        //Grabs data
        get{return _color + " is the color of the car";}
        //sets data
        set{_color = value;}
    }

    //This is a property
    //Gives us the felxibility to check that the data being stored is correct
    //lets only certain things acess data, make things read or write only
    public string Owner
    {
        //get keyword is how the data is shared
        get{return _owner + " is the owner of this car.";}
        
        //set keyword is how you can change the data being stored
        set{_owner = value+ " Owner";}


    }

    public int Fuel
    {
        //get keyword is how the data is shared
        get{return _fuel;}
        
        //set keyword is how you can change the data being stored
        set{
            
            if(value <= 100 && value >= 0)
            {
                _fuel = value;
            }
            else
            {
                _fuel=100;
                Console.WriteLine("Fuel can only hold from 0 to 100");
                //throw new Exception("Fuel can only hold from 0 to 100");
            }
        }


    }
}