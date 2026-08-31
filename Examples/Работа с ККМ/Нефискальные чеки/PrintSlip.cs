using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class PrintSlip : Sample
{
    public const string GroupPath = "Работа с ККМ|Нефискальные чеки";
    public const string Title = "Печать нефискального документа";
    public const int SortOrder = 0;

    public async Task<ServerKkm> PostPrintSlip()
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
        await kkm.PrintSlip();

        return kkm;
    }
}