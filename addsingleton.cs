// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
// abstract factory
public interface IDataBaseConnection{
    public void connect();
}
public class SqlConnector:IDataBaseConnection{
    public void connect(){
        Console.WriteLine("connect to SQL database");
    }
}
public class PostSqlConnector:IDataBaseConnection{
    public void connect(){
        Console.WriteLine("connect to postgresql");
    }
}
//client code 
public class DataBaseClient{
    private IDataBaseConnection database;
    public DataBaseClient(IDataBaseConnection x){
        database=x;
    }
    public void connectionStatus(){
        database.connect();
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        IDataBaseConnection x=new PostSqlConnector();
        DataBaseClient client=new DataBaseClient(x); 
        client.connectionStatus();
    }
}