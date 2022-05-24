// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumOfIntNumbers(int m, int n)
{ 
        int temp =0;
        if(n<m)
        {
            temp=n;
            n=m;
            m=temp;
        }
        if (m == n)
         {
              return n;
          }
          return n + SumOfIntNumbers(m,n - 1);
}
Console.WriteLine("input your first number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input your second number: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write(SumOfIntNumbers(x,y));

//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*int SumOfDigits(int a)
{
    if (a / 10 != 0)
    {
        return a % 10 + SumOfDigits(a / 10);
    }
    return a % 10;
}
Console.WriteLine("input your number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("sum of digits is -> " + SumOfDigits(x));*/
