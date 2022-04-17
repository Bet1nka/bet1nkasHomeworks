/*
// 1. : Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine( " input First integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( " input Second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1>num2)
{
    Console.WriteLine("First is max - " + num1);
    Console.WriteLine("Second is min - " + num2);
} 
 else
{
    Console.WriteLine("Second is max - " + num2);
    Console.WriteLine("First is min - " + num1);

}


//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine( " input First integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( " input Second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( " input First integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( " input Third integer number: ");

if (num1>num2&num1>num3)
     Console.WriteLine("First number is max - " + num1);
if (num2>num1&num2>num3)    
     Console.WriteLine("Second number is max - " + num2);
if (num3>num1&num3>num2)
     Console.WriteLine("Third number is max - " + num3);

     



//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine( " input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 ==0)
{
  Console.WriteLine(num + " even number");
}
else
{
    Console.WriteLine(num + " odd number");
}

*/

//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
 
 Console.WriteLine( " input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num/num;
while(current<=num);
if(num % 2 ==0)
   Console.WriteLine(current + " ");
   current++;
   


