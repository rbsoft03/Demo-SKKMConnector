using System.Globalization;
using SkkmConnector;

namespace SkkmNugetSample;

public class ConnectionSettings
{
    public const string DateFormat = "yyyy-MM-dd";
    public const string HintHost = "localhost";
    public const string HintPort = "4398";
    public const string HintToken = "api_key";
    public const string HintDevice = "Emu";
    public const string HintCashier = "Иванов А.И.";
    public const string HintCashierVatin = "7722345678";

    public string Host { get; set; } = "";
    public int Port { get; set; }
    public string Token { get; set; } = "";
    public string Device { get; set; } = "";
    public string Cashier { get; set; } = "";
    public string CashierVatin { get; set; } = "";
    public string DocumentId { get; set; } = "";
    public string FromText { get; set; } = "";
    public string ToText { get; set; } = "";
    public DateTime From { get; private set; } = DateTime.Today.AddDays(-7);
    public DateTime To { get; private set; } = DateTime.Today;

    public bool TryRead(bool needDocumentId, out string error)
    {
        if (Host.Trim().Length == 0)
        {
            error = "Укажите хост сервера ККМ.";
            return false;
        }

        if (Port is < 1 or > 65535)
        {
            error = "Укажите порт сервера ККМ.";
            return false;
        }

        if (needDocumentId && DocumentId.Trim().Length == 0)
        {
            error = "Укажите Id документа.";
            return false;
        }

        if (!TryParseDate(FromText, DateTime.Today.AddDays(-7), "с", out var from, out error))
            return false;
        if (!TryParseDate(ToText, DateTime.Today, "по", out var to, out error))
            return false;
        if (from > to)
        {
            error = "Дата «с» позже даты «по».";
            return false;
        }

        From = from;
        To = to;
        error = "";
        return true;
    }

    private static bool TryParseDate(string text, DateTime fallback, string label, out DateTime date, out string error)
    {
        var value = text.Trim();
        if (value.Length == 0)
        {
            date = fallback;
            error = "";
            return true;
        }

        if (DateTime.TryParseExact(value, DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
        {
            error = "";
            return true;
        }

        error = $"Укажите дату «{label}» в формате {DateFormat}.";
        return false;
    }
}
