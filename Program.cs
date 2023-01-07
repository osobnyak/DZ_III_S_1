//получаем число. Определить чётное или нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int numOst = num%2;

if (numOst == 0)
{
    Console.WriteLine("да, чётное");
}
else 
{
    Console.WriteLine("нет, не чётное");
}
