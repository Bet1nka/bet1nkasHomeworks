//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrom(int x)
{
    if (x<9999||x>100000)
    {        
        Console.WriteLine("sorry, incorrect number :(");
        return;
    }
    if (x/10000==x%10 && x/1000%10==x/10%10)
      Console.WriteLine(x +"OMG Look at this number!!! you can read this same from both side");
    else 
      Console.WriteLine(x +" OH so boring this number is simple");
           
}
Console.WriteLine("Input number with 5 symbols");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);

*/
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Findin3d(double a1,double b1,double c1,double a2, double b2, double c2)
{
  return Math.Sqrt((a2-a1)*(a2-a1)+(b2-b1)*(b2-b1)+(c2-c1)*(c2-c1));
}
Console.WriteLine("Input x coordinate for A");
double cax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coordinate for A");
double cay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z coordinate for A");
double caz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x coordinate for B");
double cbx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coordinate for B");
double cby = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z coordinate for B");
double cbz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Findin3d(cax,cay,caz,cbx,cby,cbz));

/*
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