namespace DependencyInjectionDemo
{
  public class Worker
  {
    private ILogger _logger;
    public Worker(ILogger logger)
    {
      _logger = logger;
      _logger.OutputMessage("This constructor has been injected with a logger!");
    }
    public void DoSomeWork(ILogger logger)
    {
      logger.OutputMessage("This methods has been injected with a logger!");
    }
  }
}