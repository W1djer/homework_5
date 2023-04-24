string [] Input()
{
    Console.Write("Введите данные массива через пробел: ");
    string[] array = Console.ReadLine().Split(" ").ToArray();
    return array;
}
Input();
