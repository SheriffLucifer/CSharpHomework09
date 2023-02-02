// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.


Console.Clear();
int start = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int end = 1;
;
Console.WriteLine($"{start} -> {ShowIntegers(start, end)}");


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

string ShowIntegers(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    else
    {
        return start + " " + ShowIntegers(start - 1, end);
    }
}

// int n = InputInt("Введите положительное число");
// int m = 1;
// if (n < 1)
// {
//     Console.WriteLine("Ввели не положительное число");
// }
// Console.WriteLine(NaturalNumber(n, m));

// int NaturalNumber(int n, int m)
// {
//     if (n == m)
//         return n;
//     else
//         Console.Write($"{NaturalNumber(n, m + 1)}, ");
//     return m;
// }

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }