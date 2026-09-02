using SkkmConnector;

namespace SkkmNugetSample.Examples;

public class RequestKM : Sample
{
    public const string GroupPath = "Работа с ККМ|Работа с маркировкой";
    public const string Title = "Проверка КМ";

    public async Task<ServerKkm> PostRequestKM()
    {
        kkm.DeviceName = deviceName;
        kkm.MarkingCode = "MDEwNDYwNzAxMDM1MDI0NjIxNURzPkpSak5FIWpaIR05M2RHVno=";
        kkm.PlannedStatus = MarkingPlannedStatus.Sold;
        kkm.MarkingQuantity = 1;
        kkm.WaitForResult = true;
        await kkm.RequestKM();

        return kkm;
    }
}