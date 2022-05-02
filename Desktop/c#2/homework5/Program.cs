/*
//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void Degree(int a, int b)
{
  int a1=1;
  for(int count = 0; count<b;count++)
  {
   a1 = a1*a;
  }
 Console.WriteLine (a1); 
}
Console.WriteLine(" input your first number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" input your second number: ");
int B = Convert.ToInt32(Console.ReadLine());
Degree(A,B);

*/

// not working with zero in numbers;
//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int ReturnSumOfNumbers (int x)
{
    int x1 = 0;
    int count = 0;
    while(x%10>0)
    {
        x1 = x1+x%10;
        x = x/10;
        count++;
    }
    return x1;
}
Console.WriteLine("input number - ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReturnSumOfNumbers(x));


/*
//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.}


int [] CreateRandomArray(int size)
{
  int [] array = new int [size];
  for(int i=0;i<size;i++)
    array[i]=new Random().Next(1,23);   
  return array;
}
void ShowArray(int[] array)
{
  for(int i=0;i<array.Length;i++)
  {
    Console.Write(array[i]+" ");
  }
}
int[] myarr = CreateRandomArray(8);
ShowArray(myarr);
*/