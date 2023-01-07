//получаем 3 числа, определяем и показываем максимальное

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int numMax = num1;

if (num1<num2)
{
    numMax = num2;
}
if (numMax<num3)
{
    numMax = num3;
}
Console.Write("max = ");
Console.WriteLine(numMax);




//Console.WriteLine("Hello, World!");
