using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;
using SkkmConnector;

namespace SkkmNugetSample;

public static class ResponseText
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    public static string Format(ServerKkm kkm)
    {
        var envelope = new JsonObject();

        if (kkm.LastResult.ValueKind is not JsonValueKind.Undefined and not JsonValueKind.Null)
            envelope["Result"] = JsonNode.Parse(kkm.LastResult.GetRawText());

        envelope["Code"] = kkm.ErrorCode;
        envelope["Description"] = kkm.ErrorDescription;
        envelope["Success"] = kkm.Ok;

        return envelope.ToJsonString(JsonOptions);
    }
}
