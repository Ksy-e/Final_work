string[] FindValueLess(string[] array, int n)
{
    string resultString = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n) resultString = resultString + array[i] + " ";
    }
    string[] newArray = resultString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return newArray;
}

Console.Write("Введите элементы массива через пробел: ");
string input = (Console.ReadLine()!);
int n = 3;
string[] array = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", FindValueLess(array, n))}]");