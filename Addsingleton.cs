// Online C# Editor for free // Write, Edit and Run your C# code using C# Online Compiler 
using System
using System.Collections.Generic
public interface IFly {
  public void Fly()
}
public class Bird: IFly {
  public Guid Id
  public Bird() {
    Id = Guid.NewGuid()
  }
  public void Fly() {
    Console.WriteLine($"Bird with {Id} can fly")
  }
}
public interface IServiceProvider {
  public void AddSingleton < T > () where T: new()
  public T GetService < T > () where T: new()
}
public class ServiceProvider: IServiceProvider {
  Dictionary < Type, object > dict = new Dictionary < Type, object > ()
  public void AddSingleton < T > () where T: new() {
    if (!dict.ContainsKey(typeof (T))) {
      dict[typeof (T)] = new T()
    }
  }
  public T GetService < T > () where T: new() {
    if (dict.TryGetValue(typeof (T), out object service)) {
      return (T) service
    }
    throw new Exception("invalid Arguent is passed")
  }
}
public class HelloWorld {
  public static void Main(string[] args) {
    IServiceProvider serviceProvider = new ServiceProvider()
    serviceProvider.AddSingleton < Bird > ()
    Bird x = serviceProvider.GetService < Bird > ()
    Bird y = serviceProvider.GetService < Bird > ()
    x.Fly()
    y.Fly()
  }
}
