using Fluxor;

namespace TestFluxorJsonElement;

public class LoggingMiddleware(ILogger<LoggingMiddleware> logger) : Middleware
{
    public override Task InitializeAsync(IDispatcher dispatcher, IStore store)
    {
        logger.LogInformation("Store initialized");
        return Task.CompletedTask;
    }

    public override void AfterInitializeAllMiddlewares()
    {
        logger.LogInformation("All middlewares initialized");
    }

    public override void BeforeDispatch(object action)
    {
        logger.LogInformation("Action dispatched: {@Action}", action);
    }

    public override void AfterDispatch(object action)
    {
        logger.LogInformation("Action reduced: {@Action}", action);
    }
}