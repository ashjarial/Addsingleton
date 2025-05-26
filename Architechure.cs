// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class SeatCategory{
    private string _category;
    public SeatCategory(string category){
        _category=category;
    }
    public void AvailableSeat(){
        if(_category=="Premium")Console.WriteLine("Available seats are 34");
        else if(_category=="Business")Console.WriteLine("Available seats are 54");
        else throw new Exception("The premium is not defined");
        
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        var Pasenger1=new SeatCategory("Economic");
        Pasenger1.AvailableSeat();
    }
}

//in the above code we can't add the another category , and it violated the property of the solid principle that class should be open for extension but close for modification, 
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public interface ICategory{
    public void AvailableSeat();
}
public class Premium:ICategory{
    public void AvailableSeat(){
        Console.WriteLine("The available seats of Premium are 34");
    }
}
public class Business:ICategory{
public void AvailableSeat(){
        Console.WriteLine("The available seats of Bunsines are 45");
    }
}
public class Economic:ICategory{
    public void AvailableSeat(){
        Console.WriteLine("The available seats of Economic are 56");
    }
}

public class Factory{
    private ICategory _category;
    public Factory(ICategory category){
        _category=category;
        
    }
    public void EmptySeat(){
        _category.AvailableSeat();
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        ICategory passenger1 = new Business();
        var x = new Factory(passenger1);
        x.EmptySeat();
    }
}

// in this code we can add the n amount of the categroy which make the code more flexible and scalable compare to prevous onw