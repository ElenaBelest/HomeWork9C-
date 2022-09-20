Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("64) Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
        Console.WriteLine("66) Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.WriteLine("68) Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;
            case 64: Numbers(); break;
            // case 66: MinSumRows(); break;
            // case 88: ProductOfArrays(); break;
            default: Console.WriteLine("error"); break;
        }
    }
}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void Numbers()
{
Console.Write("Enter first number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Numbers from {number} to {number2}: " + NumbersRec(number,number2));
}

string NumbersRec(int number, int number2)
{
    if (number <= number2) return $"{number}" + " " + NumbersRec(number + 1, number2);
    else return String.Empty;
}
