public class Menu2
{
    private string _name;
    public string Name
    {
        get{ return _name;}
        set{ _name =value;}
    }
    private int _mousePrice;
    private int _keyboardPrice;
    private int _phonePrice;
    private int _laptopPrice;
    private int _total;
    public int Total
    {
        get{ return _total;}
        set{ _total =value;}
    }

    public Menu2()
    {
        _name = "Stephen";
        _mousePrice = 10;
        _keyboardPrice =99;
        _phonePrice = 1000;
        _laptopPrice =2000;
    }
    //
    public void GreetUser()
    {
        Console.Clear();
        Console.WriteLine("Hello, " + _name +"! What can I do for you?");
        Console.WriteLine("1. Buy an item");
        Console.WriteLine("2. Checkout");
    }
    public void BuyItem()
    {
        Console.WriteLine("1 Mouse: $"+ _mousePrice);
        Console.WriteLine("2 Keyboard: $"+ _keyboardPrice);
        Console.WriteLine("3 Phone: $"+ _phonePrice);
        Console.WriteLine("4 Laptop: $"+ _laptopPrice);
        string answer = Console.ReadLine();
        if(answer =="1")
        {
            _total+= _mousePrice;
        }
        if(answer =="2")
        {
            _total+= _keyboardPrice;
        }
        if(answer =="3")
        {
            _total+= _phonePrice;
        }
        if(answer =="4")
        {
            _total+= _laptopPrice;
        }
        Console.WriteLine("Your Current Total is $" + _total);
    
    }



}