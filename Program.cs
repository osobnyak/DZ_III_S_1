//принимаем число, показываем все чётные числа от 1 до N
//своими силами не смог сделать ((( нащёл код который показывает и чётные и ни чётные из массива.
//Убрал часть с нечётными. Но половину кода всё равно не понимаю...

using System;
    class RecExercise6
    {
        public static void Main()
        {
    int n;
	     
    Console.Write("укажите деапазон массива (до какого числа от 1) : ");
    n = Convert.ToInt32(Console.ReadLine());
     
    Console.WriteLine("чётные от 1 до {0}: ", n);
    EvenAndOdd(2, n);//call the function EvenAndOdd for even numbers 
    
    Console.WriteLine("\n\n");
     
    return ;
}
static void EvenAndOdd(int stVal, int n)
{
    if(stVal > n)
        return ;
    Console.Write(" {0}  ", stVal);
    EvenAndOdd(stVal+2, n);
}
}