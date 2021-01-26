using System;

namespace DependencyInjectionDemo
{
  public class ConsoleLogger : ILogger
  {
    public void OutputMessage(string message)
    {
      Console.WriteLine(message);
    }
  }
}