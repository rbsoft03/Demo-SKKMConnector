using System.IO;

namespace SkkmNugetSample.Ui;

public static class ExampleSource
{
    public static string Read(ExampleItem example)
    {
        string fileName = example.Instance.GetType().Name + ".cs";
        foreach (var root in Roots())
        {
            string examplesDir = Path.Combine(root, "Examples");
            if (!Directory.Exists(examplesDir))
                continue;

            // Ищем файл примера в Examples и во всех подпапках (например «Пример печати с чеков»).
            var match = Directory.GetFiles(examplesDir, fileName, SearchOption.AllDirectories).FirstOrDefault();
            if (match != null)
                return Unindent(Strip(File.ReadAllText(match)));
        }
        return "";
    }

    private static string Strip(string text)
    {
        int start = text.IndexOf("    public async Task", StringComparison.Ordinal);
        if (start < 0)
            return text.Trim();
        return text[start..].TrimEnd().TrimEnd('}').TrimEnd();
    }

    private static string Unindent(string text)
    {
        var lines = text.Replace("\r\n", "\n").Split('\n');
        int pad = lines
            .Where(line => line.Trim().Length > 0)
            .Select(line => line.TakeWhile(char.IsWhiteSpace).Count())
            .DefaultIfEmpty(0)
            .Min();
        if (pad <= 0)
            return text;
        return string.Join("\n", lines.Select(line => line.Length >= pad ? line[pad..] : line));
    }

    private static IEnumerable<string> Roots()
    {
        yield return AppContext.BaseDirectory;

        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        while (dir != null)
        {
            if (File.Exists(Path.Combine(dir.FullName, "SkkmNugetSample.csproj")))
            {
                yield return dir.FullName;
                yield break;
            }
            dir = dir.Parent;
        }
    }
}
