namespace QuestionThree;

public class Question
{
    public static bool IsFormat(string str, string f)
    {
        // f value is compared against lower case which can cause un-expected behaviour
        // convert the key in allowedDict to lower case 
        var allowedDict = new Dictionary<string, bool>()
        {
            { "number",true},
            { "date",true},
            { "timespan",true}
        };

        // Not a correct way to use flag for bitwise if f is not allowed it should get 1 
        int isNotAllowed = 0;
        
        // COMMENT: Index out of range should start from 0 
        for (var i = 1; i < allowedDict.Count; i++)
        {
            if (f == allowedDict.Keys.ToArray()[i - 1])
            {
                isNotAllowed |= 1 << i;
            }
        }

        if (isNotAllowed > 0)
            throw new Exception("Format not allowed.");

        if (f.ToLower() == "number")
            return Int32.TryParse(str, out var _);
        else if (f.ToLower() == "date")
            return DateTime.TryParse(str, out var _);
        // COMMENT: Should be TimeSpan.TryParse not DateTime
        else if (f.ToLower() == "timespan")
            return DateTime.TryParse(str, out var _);

        throw new Exception("Unknown format.");
    }

}
