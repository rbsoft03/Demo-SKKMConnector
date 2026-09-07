using System.IO;
using System.Text.RegularExpressions;

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
                return FormatForDisplay(File.ReadAllText(match));
        }
        return "";
    }

    // Как в реальном клиентском коде: using + создание коннектора + тело запроса.
    private static string FormatForDisplay(string text)
    {
        int start = text.IndexOf("    public async Task", StringComparison.Ordinal);
        if (start < 0)
            return text.Trim();

        int brace = text.IndexOf('{', start);
        if (brace < 0)
            return text.Trim();

        int depth = 0;
        int end = -1;
        for (int i = brace; i < text.Length; i++)
        {
            char c = text[i];
            if (c == '{') depth++;
            else if (c == '}')
            {
                depth--;
                if (depth == 0)
                {
                    end = i;
                    break;
                }
            }
        }
        if (end < 0)
            return text.Trim();

        string body = Unindent(text[(brace + 1)..end].TrimEnd());
        body = Regex.Replace(body, @"\r?\nreturn kkm;\s*$", "", RegexOptions.Multiline);
        body = body.TrimEnd();

        return "using RBSoftSkkm;\n\nusing var kkm = new SkkmConnector();\n" + body + "\n";
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
