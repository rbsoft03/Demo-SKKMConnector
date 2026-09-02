using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Avalonia.Controls;
using Avalonia.Controls.Documents;
using Avalonia.Media;

namespace SkkmNugetSample.Ui;

// Подсветка C# и JSON в цветах Visual Studio (тёмная тема).
// Соседний текст одного цвета склеивается в один Run — иначе большой файл
// (напр. пример со 100+ позициями) породил бы десятки тысяч inline-объектов.
public static class CSharpHighlighter
{
    private static readonly HashSet<string> Keywords = new()
    {
        "using", "namespace", "public", "private", "protected", "internal", "static",
        "class", "struct", "enum", "interface", "async", "await", "var", "new",
        "return", "if", "else", "for", "foreach", "while", "throw", "try", "catch",
        "finally", "true", "false", "null", "this", "base", "const", "readonly",
        "void", "int", "long", "bool", "string", "decimal", "double", "float",
        "object", "byte", "short", "uint", "ulong", "get", "set", "out", "ref",
        "in", "is", "as", "typeof", "nameof", "override", "virtual", "abstract",
        "sealed", "partial", "where", "from", "select", "into", "join", "let"
    };

    private static readonly HashSet<string> Types = new()
    {
        "ServerKkm", "Task", "InvalidOperationException", "Exception",
        "FiscalLine", "TextLine", "BarcodeLine", "SeparatorLine", "PictureLine",
        "PrintLine", "TemplateItem", "PrintFormBarcode", "Picture", "Payments", "Vendor", "Agent", "Marking", "Industry", "UserAttribute",
        "OperationalAttribute", "ElectronicPayment", "FractionalQuantity",
        "CorrectionData", "Correction105Taxes", "CorrectionTypes", "LineStyle", "CheckType", "TaxSystem"
    };

    private static readonly IBrush Default = new SolidColorBrush(Color.Parse("#DCDCDC"));
    private static readonly IBrush Keyword = new SolidColorBrush(Color.Parse("#569CD6"));
    private static readonly IBrush Type = new SolidColorBrush(Color.Parse("#4EC9B0"));
    private static readonly IBrush Str = new SolidColorBrush(Color.Parse("#CE9178"));
    private static readonly IBrush Comment = new SolidColorBrush(Color.Parse("#6A9955"));
    private static readonly IBrush Number = new SolidColorBrush(Color.Parse("#B5CEA8"));
    private static readonly IBrush Key = new SolidColorBrush(Color.Parse("#9CDCFE"));

    // <summary> типов и полей из XML-документации коннектора
    private static Dictionary<string, string>? _summaries;
    private static readonly HashSet<string> TypeNames = new(StringComparer.Ordinal);
    private static Dictionary<string, string> Summaries => _summaries ??= LoadSummaries();

    private static Dictionary<string, string> LoadSummaries()
    {
        var types = new Dictionary<string, string>(StringComparer.Ordinal);
        var members = new Dictionary<string, string?>(StringComparer.Ordinal); // null — неоднозначное имя
        try
        {
            var path = Path.Combine(AppContext.BaseDirectory, "SkkmConnector.xml");
            if (File.Exists(path))
            {
                foreach (var member in XDocument.Load(path).Descendants("member"))
                {
                    var name = (string?)member.Attribute("name");
                    var summary = member.Element("summary");
                    if (name is null || summary is null || name.Length < 2)
                        continue;

                    char kind = name[0];
                    if (kind != 'T' && kind != 'P' && kind != 'F')   // типы, свойства, поля
                        continue;

                    var doc = BuildDoc(summary);
                    if (doc.Length == 0)
                        continue;

                    var shortName = ShortName(name);
                    if (kind == 'T')
                    {
                        types[shortName] = doc;
                        TypeNames.Add(shortName);
                    }
                    else if (members.TryGetValue(shortName, out var existing))
                    {
                        if (existing != null && existing != doc)
                            members[shortName] = null; // разные описания под одним именем — пропускаем
                    }
                    else
                    {
                        members[shortName] = doc;
                    }
                }
            }
        }
        catch
        {
            // нет файла или битый XML — просто без подсказок
        }

        // типы приоритетнее; неоднозначные поля не добавляем
        foreach (var kv in members)
            if (kv.Value != null && !types.ContainsKey(kv.Key))
                types[kv.Key] = kv.Value;

        return types;
    }

    private static string ShortName(string docName)
    {
        var s = docName.Length > 1 && docName[1] == ':' ? docName[2..] : docName;
        int paren = s.IndexOf('(');
        if (paren >= 0) s = s[..paren];
        int dot = s.LastIndexOf('.');
        return dot >= 0 ? s[(dot + 1)..] : s;
    }

    private static string BuildDoc(XElement el)
    {
        var sb = new StringBuilder();
        foreach (var node in el.Nodes())
            RenderDoc(node, sb);

        var lines = new List<string>();
        foreach (var raw in sb.ToString().Split('\n'))
        {
            var line = Regex.Replace(raw, @"[ \t]+", " ").Trim();
            if (line.Length > 0)
                lines.Add(line);
        }
        return string.Join("\n", lines);
    }

    private static void RenderDoc(XNode node, StringBuilder sb)
    {
        switch (node)
        {
            case XText t:
                sb.Append(t.Value);
                break;
            case XElement e:
                switch (e.Name.LocalName)
                {
                    case "para":
                        sb.Append('\n');
                        foreach (var c in e.Nodes()) RenderDoc(c, sb);
                        sb.Append('\n');
                        break;
                    case "br":
                        sb.Append('\n');
                        break;
                    case "see":
                    case "seealso":
                        var cref = (string?)e.Attribute("cref");
                        if (!string.IsNullOrEmpty(cref)) sb.Append(ShortName(cref));
                        else foreach (var c in e.Nodes()) RenderDoc(c, sb);
                        break;
                    default:
                        foreach (var c in e.Nodes()) RenderDoc(c, sb);
                        break;
                }
                break;
        }
    }

    public static void Apply(string code, InlineCollection target)
    {
        target.Clear();

        var buffer = new StringBuilder();
        var brush = Default;

        void Emit(int start, int end, IBrush color)
        {
            if (!ReferenceEquals(color, brush) && buffer.Length > 0)
            {
                target.Add(new Run(buffer.ToString()) { Foreground = brush });
                buffer.Clear();
            }
            brush = color;
            buffer.Append(code, start, end - start);
        }

        int i = 0, n = code.Length;
        string prev = "";
        while (i < n)
        {
            char c = code[i];
            int start = i;

            if (c == '/' && i + 1 < n && code[i + 1] == '/')          // // комментарий
            {
                while (i < n && code[i] != '\n') i++;
                Emit(start, i, Comment); prev = "";
            }
            else if (c == '/' && i + 1 < n && code[i + 1] == '*')     // /* комментарий */
            {
                i += 2;
                while (i < n && !(code[i] == '*' && i + 1 < n && code[i + 1] == '/')) i++;
                if (i < n) i += 2;
                Emit(start, i, Comment); prev = "";
            }
            else if (c == '"' || (c == '@' && i + 1 < n && code[i + 1] == '"') || c == '\'')  // строка / символ
            {
                i = SkipQuoted(code, i, n);
                Emit(start, i, Str); prev = "";
            }
            else if (char.IsLetter(c) || c == '_')                    // слово (ключевое / тип / прочее)
            {
                while (i < n && (char.IsLetterOrDigit(code[i]) || code[i] == '_')) i++;
                string word = code.Substring(start, i - start);
                bool hasDoc = Summaries.TryGetValue(word, out var tip);
                bool isType = Types.Contains(word) || prev == "new" || TypeNames.Contains(word);
                var color = Keywords.Contains(word) ? Keyword
                          : isType ? Type
                          : Default;

                if (hasDoc && !ReferenceEquals(color, Keyword))
                {
                    if (buffer.Length > 0) { target.Add(new Run(buffer.ToString()) { Foreground = brush }); buffer.Clear(); }
                    var chip = new TextBlock { Text = word, Foreground = color, Background = Brushes.Transparent };
                    ToolTip.SetTip(chip, new TextBlock { Text = tip, MaxWidth = 380, TextWrapping = TextWrapping.Wrap });
                    target.Add(new InlineUIContainer(chip));
                    prev = word;
                }
                else
                {
                    Emit(start, i, color); prev = word;
                }
            }
            else if (char.IsDigit(c))                                 // число
            {
                while (i < n && (char.IsLetterOrDigit(code[i]) || code[i] == '.' || code[i] == '_')) i++;
                Emit(start, i, Number); prev = "";
            }
            else                                                      // пробелы, скобки, операторы
            {
                i++;
                Emit(start, i, Default);
                if (!char.IsWhiteSpace(c)) prev = "";
            }
        }

        if (buffer.Length > 0)
            target.Add(new Run(buffer.ToString()) { Foreground = brush });
    }

    // Пропускает строку "...", дословную @"...""..." или символ '\''; возвращает индекс за закрывающей кавычкой.
    private static int SkipQuoted(string code, int i, int n)
    {
        bool verbatim = code[i] == '@';
        char quote = verbatim ? '"' : code[i];
        i += verbatim ? 2 : 1;
        while (i < n)
        {
            if (verbatim)
            {
                if (code[i] == '"' && i + 1 < n && code[i + 1] == '"') { i += 2; continue; }
            }
            else if (code[i] == '\\' && i + 1 < n) { i += 2; continue; }

            if (code[i] == quote) { i++; break; }
            i++;
        }
        return i;
    }

    // Подсветка JSON ответа теми же кистями, что и C#.
    public static void ApplyJson(string json, InlineCollection target)
    {
        target.Clear();
        if (string.IsNullOrEmpty(json))
            return;

        var buffer = new StringBuilder();
        var brush = Default;

        void Emit(int start, int end, IBrush color)
        {
            if (!ReferenceEquals(color, brush) && buffer.Length > 0)
            {
                target.Add(new Run(buffer.ToString()) { Foreground = brush });
                buffer.Clear();
            }
            brush = color;
            buffer.Append(json, start, end - start);
        }

        int i = 0, n = json.Length;
        while (i < n)
        {
            char c = json[i];
            int start = i;

            if (c == '"')
            {
                i = SkipQuoted(json, i, n);
                Emit(start, i, IsJsonPropertyName(json, i, n) ? Key : Str);
            }
            else if (char.IsDigit(c) || (c == '-' && i + 1 < n && char.IsDigit(json[i + 1])))
            {
                if (c == '-') i++;
                while (i < n && (char.IsDigit(json[i]) || json[i] is '.' or 'e' or 'E' or '+' or '-'))
                    i++;
                Emit(start, i, Number);
            }
            else if (char.IsLetter(c))
            {
                while (i < n && char.IsLetter(json[i])) i++;
                string word = json.Substring(start, i - start);
                Emit(start, i, word is "true" or "false" or "null" ? Keyword : Default);
            }
            else
            {
                i++;
                Emit(start, i, Default);
            }
        }

        if (buffer.Length > 0)
            target.Add(new Run(buffer.ToString()) { Foreground = brush });
    }

    // После строки — двоеточие (с пробелами) значит, что это имя свойства.
    private static bool IsJsonPropertyName(string json, int i, int n)
    {
        while (i < n && char.IsWhiteSpace(json[i])) i++;
        return i < n && json[i] == ':';
    }
}
