using System;

namespace DependencyInjectionDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      DependencyInject();
    }
    static void DependencyInject()
    {
      ILogger logger = new TextFileLogger();
      Worker di = new Worker(logger);
      di.DoSomeWork(logger);
      logger = new ConsoleLogger();
      di = new Worker(logger);
      di.DoSomeWork(logger);
    }
  }
}
