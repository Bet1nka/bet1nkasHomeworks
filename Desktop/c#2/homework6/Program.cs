//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// не понимаю можно ли сделать так, чтоб пользователь вводил числа и размер массива был по факту введеных чисел, 
//а не так, что нужно заранее обьявить колличество введенных чисел.

/*int[] CreateArray(int size)
{
  int[] array = new int[size];
  for(int i=0;i<size;i++)
  {
    Console.Write("input "+i+" element: ");
    array[i]=Convert.ToInt32(Console.ReadLine());
  }
  return array;
}
void ShowArray(int[] array)
{
  for(int i=0;i<array.Length;i++)
    Console.Write(array[i] + " ");
}
void NumbersBiggerThanNull(int[]array)
{
  int count=0;
    for(int i=0; i<array.Length;i++)
    {
        if(array[i]>0)
        {
         count++;
        }
    }
    Console.WriteLine("You input "+count+" numbers bigger than zero");
}
int[] myarr= CreateArray(7);
ShowArray(myarr);
NumbersBiggerThanNull(myarr);

*/

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void ConvertFrom10to2 (int x)
{
    int x1=x;
    int yn;
    int count=1;
    int itog=0;

    while(x1>0)
  {
    x1=x/2;
    yn=x-x1*2;
    x=x1;
    itog=itog+yn*count;
    count=count*10;
  }
  Console.WriteLine(itog);
}
Console.WriteLine("input - x ");
int a = Convert.ToInt32(Console.ReadLine());
ConvertFrom10to2(a);
/*

//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//k1*x+b1=k2*x+b2
    //x=(b2-b1)/(k1-k2)
    //y=k1(b2-b1)/(k1-k2)+b1
void CrossLineDot(double a, double b, double c, double d)
{
  double x =(c-a)/(b-d);
  double y=b*(c-a)/(b-d)+a;
  if(b==d&&a==c)
  {
    Console.WriteLine("line is same");
  }
  else if(b==d)
  {
    Console.WriteLine("line is parallel");
  }
  Console.WriteLine(x+ "-x "+ y+ "-y");
}
Console.WriteLine("Input  b1 ");
double bf = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input  k1 ");
double kf = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input  b2 ");
double bs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input  k2 ");
double ks = Convert.ToInt32(Console.ReadLine());
CrossLineDot(bf,kf,bs,ks);
*/