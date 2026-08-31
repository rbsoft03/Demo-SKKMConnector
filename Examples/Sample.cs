using SkkmConnector;

namespace SkkmNugetSample.Examples;

/// <summary>
/// Environment запроса (как переменные Bruno слева). Хост, порт и токен
/// подставляются в сессию; касса и кассир — в тело запроса в коде примера.
/// </summary>
public class Sample
{
    public ServerKkm kkm { get; set; } = null!;

    /// <summary>Имя ККМ, {{SKKMDEVICE}}.</summary>
    public string deviceName = "";

    /// <summary>Имя кассира из панели подключения.</summary>
    public string cashierName = "";

    /// <summary>ИНН кассира из панели подключения.</summary>
    public string cashierVatin = "";

    /// <summary>Id документа (DocId). Тот же идентификатор в очереди называется taskId.</summary>
    public string documentId = "";

    /// <summary>Начало периода (from) из панели подключения.</summary>
    public DateTime fromDate;

    /// <summary>Конец периода (to) из панели подключения.</summary>
    public DateTime toDate;
}
