Console.Write("Enter number > 1: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 1: ");
int number2 = Convert.ToInt32(Console.ReadLine());


string NumbersRec(int number2, int number)
{
    if (number2 <= number) return $"{number2}" + " " + NumbersRec(number2 + 1, number);
    else return String.Empty;
}
Console.WriteLine(NumbersRec(number2,number));
