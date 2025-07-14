using System.Text.Json;
using Fluxor;

namespace TestFluxorJsonElement.Store;

[FeatureState]
public class JsonState
{
    public JsonElement JsonElement { get; set; }
}