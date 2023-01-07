//branch = 1
//на входе 2 числа. Определить какое больше, какое меньше. 

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    Console.Write(num1);
    Console.Write(">");
    Console.WriteLine(num2);
    Console.Write("max=");
    Console.WriteLine(num1);
}
if (num1<num2)
{
    Console.Write(num1);
    Console.Write("<");
    Console.WriteLine(num2);
    Console.Write("max=");
    Console.WriteLine(num2);
}
if (num1==num2)
{
    Console.WriteLine("числа равны");
}
