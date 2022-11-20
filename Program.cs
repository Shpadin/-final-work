
string[] array = AskArray();
string[] AskArray() 
{
    Console.Write("Введите массивы отделяя их пробелом: ");
    return Console.ReadLine().Split(" ");
}
int CountMassThan(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}
string[] result = FindMassThan(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindMassThan(string[] input, int n) {
    string[] output = new string[CountMassThan(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
    }

