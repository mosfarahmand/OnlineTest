using System.Text.RegularExpressions;

namespace QuestionTwo;

public static partial class MarkdownUtil
{
    public static string ParseMarkdown(string input)
    {
        var headerReg = HeaderRegx();
        var match = headerReg.Match(input);

        if (!match.Success) return $"{input} (no hashes)";
        
        var header = match.Groups[1].Value;
        var content = match.Groups[2].Value;

        if (header.Length > 6)
        {
            return $"{input} (too many hashes)";
        }

        if (content.StartsWith(" ") || content.Contains("  "))
        {
            return $"{input} (too many spaces between)";
        }

        return $"<h{header.Length}>{content}</h{header.Length}>";
    }

    [GeneratedRegex(@"^(#+)\s(.+)$")]
    private static partial Regex HeaderRegx();
}
