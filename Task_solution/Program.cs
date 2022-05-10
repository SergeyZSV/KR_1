// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

const int lenFirstArray = 4;
int lenResultArray = 0;

string[] firstArray = new string[lenFirstArray] { "hello", "2", "world", ":-)" };

int index = 0;
int jndex = 0;

ResultArrayLenght(firstArray);

string[] resultArray = new string[lenResultArray];

FillResultArray();
PrintArray(firstArray);
Console.WriteLine();
PrintArray(resultArray);


// Вычисление длины результирующего массива
void ResultArrayLenght(string[] array)
{
    string element = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            lenResultArray += 1;
        }
    }
}

// Заполнение результирующего массива
void FillResultArray()
{
    while (index < lenFirstArray)
    {
        if (firstArray[index].Length <= 3)
        {
            resultArray[jndex] = firstArray[index];
            jndex = jndex + 1;
        }
        index = index + 1;
    }
}

// Вывод массива
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
}