//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrom(int x)
{
   int a = x/10000;
   int b = x%10;
   int c = (x%100)/10;
   int d = (x%10000)/1000;
    if(a==b&&c==d)
       Console.WriteLine(x + "palindrom");
    else
        Console.WriteLine(x + " NOT palindrome");
    if(100000<x&&x<9999)
      Console.WriteLine ("input number with 5 symbols");
} 
Console.WriteLine("input number wit 5 symbols");
int num = Convert.ToInt32(Console.Read());
Palindrom(num);


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindIN3d(double a1,double b1,double c1,double a2, double b2, double c2)
{
  return Math.Sqrt((a2-a1)*(a2-a1)+(b2-b1)*(b2-b1)+(c2-c1)*(c2-c1));
}
Console.WriteLine("input x1");
double x1 = Convert.ToInt32(Console.Read());
Console.WriteLine("input y1");
double y1 = Convert.ToInt32(Console.Read());
Console.WriteLine("input z1");
double z1 = Convert.ToInt32(Console.Read());
Console.WriteLine("input x2");
double x2 = Convert.ToInt32(Console.Read());
Console.WriteLine("input y2");
double y2 = Convert.ToInt32(Console.Read());
Console.WriteLine("input z2");
double z2 = Convert.ToInt32(Console.Read());

Console.WriteLine(FindIN3d(x1 ,y1 ,z1 ,x2 ,y2 ,z2));


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Qubes(int n)
{
    int count = 1;
    while (count<=n)
    {
        Console.Write(count*count*count + "  ");
        count++;
    }
}
Console.WriteLine("Input N");
int N = Convert.ToInt32(Console.ReadLine());
Qubes(N);
*/