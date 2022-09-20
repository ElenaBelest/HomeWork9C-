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
            case 66: SumNumbersRec(); break;
            case 68: AckermanFunction(); break;
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

// Задача 64: Задайте значения M и N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void Numbers()
{
    Console.Write("Enter first number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter second number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Numbers from {number} to {number2}: " + NumbersRec(number, number2));
}

string NumbersRec(int number, int number2)
{
    if (number <= number2) return $"{number}" + " " + NumbersRec(number + 1, number2);
    else return String.Empty;
}

// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumNumbersRec()
{
    Console.Write("Enter first number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter second number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"The sum of the numbers from {number} to {number2} : " + SumRec(number, number2));
}

int SumRec(int number, int number2)
{
    if (number == 0) return (number2 * (number2 + 1)) / 2;
    else if (number2 == 0) return (number * (number + 1)) / 2;
    else if (number == number2) return number;
    else if (number < number2) return number2 + SumRec(number, number2 - 1);
    else return number2 + SumRec(number, number2 + 1);
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

void AckermanFunction()
{
    Console.Write("Enter first positiv number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter second positiv number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"A (m,n) = " + AckermanFunctionRec(number, number2));
}

int AckermanFunctionRec(int number, int number2)
{
    if (number == 0)
    {
        return number2 + 1;
    }
    else if (number != 0 && number2 == 0)
    {
        return AckermanFunctionRec(number - 1, 1);
    }
    else // if (number > 0 && number2 > 0)
    {
        return (AckermanFunctionRec(number - 1, AckermanFunctionRec(number, number2 - 1)));
    }
}
