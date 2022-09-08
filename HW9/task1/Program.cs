 // Задайте значения M и N. Напишите программу, которая выведет 
 // все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNaturalRow(int min, int max)
{
    if (min > max)
    {
        return;
    }
    ShowNaturalRow(min, max - 1);
    System.Console.WriteLine(max);
}

int min = Prompt ("Enter a number M -> ");
int max = Prompt ("Enter a number n -> ");
ShowNaturalRow(min, max);
