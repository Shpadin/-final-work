
string[] array = AskArray();
string[] AskArray() {
    Console.Write("Введите массивы отделяя их пробелом: ");
    return Console.ReadLine().Split(" ");
}