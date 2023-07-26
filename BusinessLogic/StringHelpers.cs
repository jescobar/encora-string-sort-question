namespace BusinessLogic;

public static class StringHelpers
{
    public static string SortingOperation(string str) {
        var frequencyDict = new Dictionary<char, int>();

        foreach(var c in str) {
            if (!frequencyDict.ContainsKey(c)) {
                frequencyDict[c] = 0;
            }
            frequencyDict[c]++;
        }

        return new string(frequencyDict.OrderByDescending(kv => kv.Value)
            .ThenBy(kv => kv.Key)
            .SelectMany(kv => Enumerable.Repeat(kv.Key, kv.Value)).ToArray()
        );
    }

}
