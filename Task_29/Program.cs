// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Input
Console.Clear();
int arraySize = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка ввода!");
int[] array = GetArrayFromUser(arraySize);
// Logic

// Output
PrintArray(array);

/////////////////////////// опеределение методов
void PrintArray(int[] arrayIn)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayIn.Length; i++)
    {
        if (i == (arrayIn.Length - 1))
        {
            Console.Write($"{arrayIn[i]} ");
        }
        else
        {
            Console.Write($"{arrayIn[i]}, ");
        }
    }
    Console.Write("]");
}

int[] GetArrayFromUser(int elementCount)
{
    int[] newArray = new int[elementCount];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = GetNumberFromUser($"Введите {i + 1} элемент массива: ", "Ошибка ввода!");
    }
    return newArray;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect == true && userNumber > 0)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}