using QuestionTwo;

Console.WriteLine(MarkdownUtil.ParseMarkdown("# Header"));
Console.WriteLine(MarkdownUtil.ParseMarkdown("## Header"));
Console.WriteLine(MarkdownUtil.ParseMarkdown("###### Header"));
Console.WriteLine(MarkdownUtil.ParseMarkdown("####### Header"));
Console.WriteLine(MarkdownUtil.ParseMarkdown("###  Header"));
Console.WriteLine(MarkdownUtil.ParseMarkdown("Header"));
