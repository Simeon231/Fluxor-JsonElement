using System.Text.Json;
using Fluxor;

namespace TestFluxorJsonElement.Store;

public class JsonEffects : Effect<StoreInitializedAction>
{
    // This is never called
    public override Task HandleAsync(StoreInitializedAction action, IDispatcher dispatcher)
    {
        var jsonElement = JsonSerializer.SerializeToElement(new { Name = "Fluxor" });
        
        dispatcher.Dispatch(new JsonAction(jsonElement));

        return Task.CompletedTask;
    }
}