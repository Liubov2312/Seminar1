Console.WriteLine("enter the first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the second number");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("max = ");
    Console.WriteLine(num1);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(num2);
}