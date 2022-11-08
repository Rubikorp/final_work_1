# Итоговая проверочная работа Geek Brains

## Задача

Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых <= 3. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

1. Написал метод отображения массива в консоль

```C#
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
```
2. Написал код обработки вводимых данных 
```C#
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
```
>после этого сразу использую метод отображения массива, чтобы видеть корректность выполнения кода

3. Написал метод, который принимает массив пользователя и с помощью цикла for и условия if выполняет фильтрацию массива, после чего выполняет отображения результата.
```C#
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
```