
using QuestionOne;
using Shouldly;

namespace QuestionOneTests;

public class GetMiddleTests
{
    [Theory]
    [InlineData("test", "es")]
    [InlineData("testing", "t")]
    [InlineData("middle", "dd")]
    [InlineData("A", "A")]
    public void GetMiddle_Test_Return_Middle_Character(string input, string expected)
    {
        // Act
        var result = StrUtility.GetMiddleCharacter(input);
        
        // Asset
        result.ShouldBe(expected);
    }
}
