// Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.


Console.Clear();
int m = GetNumberFromUser("Введите целое число M: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите целое число N: ", "Ошибка ввода!");
int sumNumbers = ShowAkkerman(m, n);
Console.WriteLine($"M = {m}, N = {n} -> A(m,n) = {sumNumbers}");

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

int ShowAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return ShowAkkerman(m - 1, 1);
    else
        return ShowAkkerman(m - 1, ShowAkkerman(m, n - 1));
}