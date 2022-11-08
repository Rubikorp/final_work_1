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

//------------------------------------------------

//Метод поиска слов, в которых меньше 3-х символов
void ArrayThreeSymbols (string[] arr)
{
    int resultLength = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            resultLength++;
        }
    }
    string[] result = new string[resultLength];
    int resultIndex = 0;
    for (int k = 0; k < arr.Length; k++)
    {
        if(arr[k].Length <= 3)
        {
           result[resultIndex] = arr[k];
           resultIndex++;
        }
    }
    PrintArray(result);
}

ArrayThreeSymbols(arr);