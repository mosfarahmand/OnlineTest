using QuestionTwo;
using Shouldly;

namespace QuestionOneTests;

public class MarkdownTests
{
    [Theory]
    [InlineData("# Header", "<h1>Header</h1>")]
    [InlineData("## Header", "<h2>Header</h2>")]
    [InlineData("###### Header", "<h6>Header</h6>")]
    [InlineData("####### Header", "####### Header (too many hashes)")
    ][InlineData("###  Header", "###  Header (too many spaces between)")]
    [InlineData("Header", "Header (no hashes)")]
    public void Parse_Markdown_header_Success(string input, string expect)
    {
        // Act
        var result = MarkdownUtil.ParseMarkdown(input);
        
        // Assert
        result.ShouldBe(expect);
    }
}
