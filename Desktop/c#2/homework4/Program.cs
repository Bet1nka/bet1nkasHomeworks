/*
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] CreateRandomArray(int size, int min, int max)
{
  int[] array = new int[size];
  for(int i=0;i<size;i++)
  {
    array[i]=new Random().Next(min, max+1);
    
     
  }
  return array;
}

void ShowArray(int[] array)
{
  for(int i=0;i<array.Length;i++)
    Console.Write(array[i] + " ");
}
void EvenNumber(int [] array)
{
    int  count = 0;
    for(int i=0;i<array.Length;i++)
    if(array[i]%2==0)
    
       count = count + 1;
    
    Console.WriteLine("in this array we have " + count + " even numbers");
}


int [] myarr = CreateRandomArray(5, 100,999+ 1);
ShowArray (myarr);
EvenNumber(myarr);


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] CreateRandomArray(int size, int min, int max)
{
  int[] array = new int[size];
  for(int i=0;i<size;i++)
  {
    array[i]=new Random().Next(min, max+1);
    
     
  }
  return array;
}

void ShowArray(int[] array)
{
  for(int i=0;i<array.Length;i++)
    Console.Write(array[i] + " ");
}
 void SumOddNumber(int [] array)
{
    int sumOdd = 0;
    for(int i=0;i<array.Length;i=i+2)
     sumOdd= sumOdd+array[i];    
   
Console.WriteLine("this is " + sumOdd + " sum of odd elements");
}    
int [] myarr = CreateRandomArray(5, -100,100+ 1);
ShowArray (myarr);
SumOddNumber (myarr);

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// вопрос как сделать с веществеными ? это нужно через double? 

int [] CreateRandomArray(int size, int min, int max)
{
  int [] array = new int [size];
  for(int i=0;i<size;i++)
    array[i]=new Random().Next(min, max+1);   
  return array;
}

void ShowArray(int[] array)
{
  for(int i=0;i<array.Length;i++)
    Console.Write(array[i] + " ");
}
 void DifOfNumbers(int[] array)
{
    int max = array[0];
    int min = array[0];
    int numdif = 0;
    for(int i=0;i<array.Length;i++)
    {
      if(max<array[i]) 
        max = array[i];
      if(min>array[i])
        min = array[i];
    }
    numdif=max-min;
    Console.WriteLine("ok, lets go " + max + " - " + min + " = "+ numdif);
}    
int [] myarr = CreateRandomArray(5, 0,100+ 1);
ShowArray (myarr);
DifOfNumbers (myarr);
*/



  



