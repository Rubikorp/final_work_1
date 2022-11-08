void PrintArray(string[] arr)
{
    Console.Write("[ ");
    for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

// Считывание данных пользователя
Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[length];

for (int i = 0; i < length; i++)
{
    Console.Write($"Ведите слово {i}:");
    string text = Console.ReadLine();
    arr[i] = text;
}
PrintArray(arr);

