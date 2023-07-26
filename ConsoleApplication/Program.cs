using BusinessLogic;

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
    Console.WriteLine(StringHelpers.SortingOperation(str));
}

