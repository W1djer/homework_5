string[] Input()
{
    Console.Write("Введите данные массива через пробел: ");
    string[] array = Console.ReadLine().Split(" ").ToArray();
    return array;
}
void Print(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
string[] Data(string[] array)
{
    int lenght = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) lenght++;
    }
    string[] output = new string [lenght];
    lenght = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            output[lenght] = array[i];
            lenght++;
        }

    }
    return output;
}
string[] massive = Input();
string[] output = Data(massive);
Print(massive);
Console.WriteLine();
Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам");
Print(output);
