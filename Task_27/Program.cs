// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Input
Console.Clear();
int userNumber = GetNumberFromUser("Введите целое положительное число: ", "Ошибка ввода!");
// Logic
int resultSumDigits = GetResultSumDigits(userNumber);
// Output
Console.WriteLine($"{userNumber} -> {resultSumDigits}");

/////////////////////////// опеределение методов
int GetResultSumDigits(int number)
{
    int result = 0;
    while(number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
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

