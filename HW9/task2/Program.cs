//   Напишите программу,
// которая найдёт сумму числа с помощью рекурсии.
// 345 -> 12

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNaturalElements(int number)
{
    
  if  (number == 0)
    {
        return 0;
    }
    return SumOfNaturalElements(number / 10) + number % 10;
}

int number = Prompt ("Enter your number -> ");
int sum = SumOfNaturalElements(number);
Console.WriteLine(sum);