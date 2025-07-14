using Fluxor;

namespace TestFluxorJsonElement.Store;

public class JsonReducer
{
    [ReducerMethod]
    public static JsonState HandleJsonAction(JsonState state, JsonAction action)
    {
        return new JsonState
        {
            JsonElement = action.JsonElement
        };
    }
}