// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Input
Console.Clear();
int userNumberA = GetNumberFromUser("Введите целое положительное число A: ", "Ошибка ввода!");
int userNumberB = GetNumberFromUser("Введите целое положительное число B: ", "Ошибка ввода!");
// Logic
int resultOfExponent = GetResultExponent(userNumberA, userNumberB);
// Output
Console.WriteLine($"{userNumberA}, {userNumberB} -> {resultOfExponent}");

/////////////////////////// опеределение методов
int GetResultExponent(int number1, int number2)
{
    int result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result *= number1;
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

