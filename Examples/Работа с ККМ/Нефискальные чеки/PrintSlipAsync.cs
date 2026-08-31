using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class PrintSlipAsync : Sample
{
    public const string GroupPath = "Работа с ККМ|Нефискальные чеки";
    public const string Title = "Асинхронная печать нефискального документа";
    public const int SortOrder = 1;

    public async Task<ServerKkm> PostPrintSlipAsync()
    {
        kkm.DeviceName = deviceName;
        kkm.Cashier = new Cashier { Name = cashierName, Vatin = cashierVatin };
        kkm.TextForPrint =
            "[center,bold]РБ-Софт: Сервер ККМ\n" +
            "[center]Нефискальный документ\n" +
            "[line]\n" +
            "Обычная строка текста\n" +
            "[QR,center]https://www.rbsoft.ru\n" +
            "[center,small]Спасибо за покупку!";
        await kkm.PrintSlipAsync();

        return kkm;
    }
}