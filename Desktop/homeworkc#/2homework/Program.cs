/*
//Главные вопросы: отличие void от int (кто, где и как применяется), что значит,что в теле и вне него должны отличаться перемнные (почему и как это выглядит).
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int ShowNumber(int n)
{
    Console.WriteLine(n + " -> ");
    int n1 = (n/10)%10;
    return(n1);      
}
int n = new Random().Next(100, 999);
int a = ShowNumber(n);
Console.WriteLine(a);


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void ShowThirdNumber(int n)
{
     Console.WriteLine(n + " ->");
    
     if (n>99&n<1000)
     {   
         int num = n%10;
         Console.WriteLine(num); 
     }

     if (n<99)
     {
         Console.WriteLine("not third number");
     }
     
     if (n>999&n<10000)
     {
         int num1 = n/10%10;
         Console.WriteLine(num1);
         
     }
}
Console.WriteLine("Input integer number: "); 
int n = Convert.ToInt32(Console.ReadLine());

ShowThirdNumber(n);
// Очень сильно затупила и не поняла как это сделать для всех чисел. ну хоть так до 10000 работает :)

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Weekends(int n)
{
    if(n>7)
    {
        Console.WriteLine("такого дня в неделе нет, дурашка, попробуй еще раз ;)");
    }
    if(n<6)
    {
        Console.WriteLine("ох черт, еще работать и работать:(");        
    }
    if(n<=6&n<=7)
    {
        Console.WriteLine("Поздравляю! сегодня Тюленимся дома ура!");
    }

}
Console.WriteLine("Введите день недели ( от 1 до 7 ): ");
int n = Convert.ToInt32(Console.ReadLine());
Weekends(n);
*/