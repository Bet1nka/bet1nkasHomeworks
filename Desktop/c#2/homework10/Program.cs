//: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
/*
string [] test ={ "Pav", "el", "the", "best", "tea","cher","ever"} ;
char[] symbols={'a','e','y','u','i','o'};
void TestString (string [] a, char [] b)
{
    int count=0;
    for(int i=0; i<a.Length;i++)
    {
        for(int j=0;j<a[i].Length;j++)
        {
            for(int c=0; c<b.Length; c++)
            {
                if (j==0&&a[i][j]==b[c])
                {
                  Console.Write("your string is " +a[i]+ " ");
                  count++;
                }
            }
        }
    }Console.WriteLine();
    Console.WriteLine(" " +count+"  strings start from vowels");
}
TestString(test,symbols);
*/
//Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

string[] fox = { "Pav", "el", "the", "best", "tea", "cher", "ever" };
string[] PairsString(string[] a)
{
    string[] kotik = new string[a.Length/2+1];
    for (int i = 0,j=0; i < a.Length - 1; i=i+2,j++)
    {       
        kotik[j] = a[i] + a[i + 1]; 
        if(a.Length%2!=0)
        kotik[kotik.Length-1]=a[a.Length-1];
    }
    return kotik;
}



void PrintArr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine();
PrintArr(PairsString(fox));