// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.



Console.Clear();
int m = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int sumNumbers = GetSumNumbers(m, n);
Console.WriteLine($"M = {m}; N = {n} -> {sumNumbers}");


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetSumNumbers(int m, int n)
{
    if (m == n) return n;
    else return n + GetSumNumbers(m, n - 1);
}
