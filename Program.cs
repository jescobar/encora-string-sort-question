Console.WriteLine("Josue Escobar - Tue 25 Jul 2023 19:22(7:22PM) - Jueves 25 de Julio De 2023 - 19:22(7:22 pm)");
int N;
Console.WriteLine("Please enter a Number that represent the number of strings to sort");

while (!int.TryParse(Console.ReadLine(), out N)){
    Console.WriteLine("Please enter a Number that represent the number of strings to sort");
}

var stringToSort = new List<string>();
for (var i = 0; i < N; i++) {
    Console.WriteLine($"Please enter the string number {i + 1}");
    stringToSort.Add(Console.ReadLine() ?? "");
}
Console.WriteLine($"Sorting Strings");
foreach(var str in stringToSort) {
    Console.WriteLine(SortingOperation(str));
}

static string SortingOperation(string str) {
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