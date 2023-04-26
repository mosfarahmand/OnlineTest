namespace QuestionOne;

public static class StrUtility
{
    public static string GetMiddleCharacter(string str)
    {
        var len = str.Length;
        var midInd = len / 2;
        var divRemainder = len % 2;
        return divRemainder == 0 
            ? str.Substring(midInd - 1, 2)
            : str[midInd].ToString();
    }
}
