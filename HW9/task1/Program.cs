// Задайте значения M и N. Напишите программу, которая выведет 
// все  натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void EvenNaturalNumbersRow(int min, int max)
{
    int i = 0;
    for (i = min; i > max; i++)
    {
        if (i % 2 == 0)
        {
           return;
        }
    }
    EvenNaturalNumbersRow(min, max - 1);
    Console.WriteLine(max);
}

int min = Prompt("Enter a number M -> ");
int max = Prompt("Enter a number N -> ");
EvenNaturalNumbersRow(min, max);