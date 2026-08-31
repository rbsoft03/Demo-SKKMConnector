using System;
using System.Collections.Generic;
using System.Text;
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
                var color = Keywords.Contains(word) ? Keyword
                          : Types.Contains(word) || prev == "new" ? Type
                          : Default;
                Emit(start, i, color); prev = word;
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
