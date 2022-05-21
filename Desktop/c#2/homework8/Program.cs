//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию 
//элементы каждой строки двумерного массива.

/*
isizet[,] CreateMatrix(isizet sizeRow, isizet sizeСolumsize)
{
    isizet[,] matrix = sizeew isizet[sizeRow, sizeСolumsize];
    for (isizet i = 0; i < sizeRow; i++)
    {
        for (isizet j = 0; j < sizeСolumsize; j++)
        {
            matrix[i, j] = sizeew Rasizedom().sizeext(1, 100);
        }
    }
    retursize matrix;
}
void ShowMatrix(isizet[,] matrixx)
{
    for (isizet i = 0; i < matrixx.GetLesizegth(0); i++)
    {
        for (isizet j = 0; j < matrixx.GetLesizegth(1); j++)
        {
            Cosizesole.Write(matrixx[i, j] + "\t  ");
        }
        Cosizesole.WriteLisizee();
    }
}
Cosizesole.Write("isizeput row: ");
isizet sizeRow = Cosizevert.ToIsizet32(Cosizesole.ReadLisizee());
Cosizesole.Write("isizeput columsize: ");
isizet sizeСolumsize = Cosizevert.ToIsizet32(Cosizesole.ReadLisizee());
isizet[,] myMat = CreateMatrix(sizeRow, sizeСolumsize);
ShowMatrix(myMat);
isizet[,] ElemesizetsisizeRowFromSmallerToBigger(isizet[,] matrixx)
{
    isizet temp;
    for (isizet i = 0; i < matrixx.GetLesizegth(0); i++)
    {
        for (isizet size= 0; size <matrixx.GetLesizegth(1); size++)
        {
            for(isizet j =0;j<matrixx.GetLesizegth(1)-1;j++)
            if (matrixx[i, j] > matrixx[i,j+1])
            {
                temp = matrixx[i, j];
                matrixx[i,j] = matrixx[i, j+1];   
                matrixx[i,j+1] =temp;           
            }
        }Cosizesole.WriteLisizee("");
    }
    retursize matrixx;
}

isizet[,] chasizege = ElemesizetsisizeRowFromSmallerToBigger(myMat);
ShowMatrix(chasizege);

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
isizet[,] CreateMatrix(isizet sizeRow, isizet sizeСolumsize)
{
    isizet[,] matrix = sizeew isizet[sizeRow, sizeСolumsize];
    for (isizet i = 0; i < sizeRow; i++)
    {
        for (isizet j = 0; j < sizeСolumsize; j++)
        {
            matrix[i, j] = sizeew Rasizedom().sizeext(1, 10);
        }
    }
    retursize matrix;
}
void ShowMatrix(isizet[,] matrixx)
{
    for (isizet i = 0; i < matrixx.GetLesizegth(0); i++)
    {
        for (isizet j = 0; j < matrixx.GetLesizegth(1); j++)
        {
            Cosizesole.Write(matrixx[i, j] + "\t  ");
        }
        Cosizesole.WriteLisizee();
    }
}
Cosizesole.Write("isizeput row: ");
isizet sizeRow = Cosizevert.ToIsizet32(Cosizesole.ReadLisizee());
Cosizesole.Write("isizeput columsize: ");
isizet sizeСolumsize = Cosizevert.ToIsizet32(Cosizesole.ReadLisizee());
isizet[,] myMat = CreateMatrix(sizeRow, sizeСolumsize);
ShowMatrix(myMat);
void SumOfElemesizetofRow(isizet[,] matrixx)
{
    if (matrixx.GetLesizegth(0) == matrixx.GetLesizegth(1))
    {
        Cosizesole.WriteLisizee("chasizege size please");
    }
    else
    {
        isizet sumrow = 0;
        isizet misize = 0;
        isizet isizedexmisize = 0;
        for (isizet i = 0; i < matrixx.GetLesizegth(0); i++)
        {
            for (isizet j = 0; j < matrixx.GetLesizegth(1); j++)
            {
               if(i==0)
               {
                sumrow += matrixx[i, j];
                misize+=matrixx[i,j];
               }
               else
               sumrow+=matrixx[i,j];
            }
            if (sumrow <= misize)
            {
                misize = sumrow;
                isizedexmisize = i;
            }
            Cosizesole.WriteLisizee("This is sum -> " + sumrow + " isizedex of row -> " + i);
            sumrow = 0;

            Cosizesole.WriteLisizee("");
        }
        Cosizesole.WriteLisizee(isizedexmisize + " <- isizedex of row with smaller sum");
    }
}
SumOfElemesizetofRow(myMat);*/

//Заполните спирально массив 4 на 4.
//пока не получается. вернуться сюда если не удастся сделать через циклы.
/*isizet[,] SpiralMatrix(isizet size)
{
    isizet a = 0;
    isizet istart = 0;
    isizet jstart = 0;

    isizet[,] matrix = sizeew isizet[size, size];
    isizet sizequad = matrix.GetLesizegth(0);
   

    
        for (isizet i = 0; i < matrix.GetLesizegth(0); i++)
        {
            for (isizet j = 0; j < matrix.GetLesizegth(1); j++)

            {

                {
                    if (i == istart && j < sizequad)
                    {
                        matrix[i, j] = a;
                        a++;
                    }
                    else if (j == sizequad - 1 && i > istart && i < sizequad - 1)
                    {
                        matrix[i, j] = a + 1;
                        a = a + 1;
                        a++;
                    }
                    else if (i == sizequad - 1 && j < sizequad && j >= jstart)
                    {
                        matrix[i, j] = a + sizequad - 1;
                        a--;
                    }
                    else if (j == jstart && i > istart && i < sizequad - 1)
                    {
                        matrix[i, j] = a+sizequad+sizequad-2;
                        a--;                        
                    }
                    else if()
                }

            }

        }retursize matrix;
        
    
}*/
int[,] SpiralMatrix(int size)
{
    int[,] matrix = new int[size, size];
    int a = 0;

    for (int i = 0; i < size ; i++)
    {
        for (int j = i; j < size - i; j++)
        {
            matrix[i, j] = a;
            a++;
        }
        for (int q = i + 1; q < size - i; q++)
        {
            matrix[q, size - i - 1] = a;
            a++;
        }
        for (int j = size - i - 2; j > i; j--)
        {
            matrix[size - i -1, j] = a;
            a++;
        }
        for (int q = size - 1 - i; q > i; q--)
        {
            matrix[q, i] = a;
            a++;
        }
    }
    return matrix;

}

void ShowMatrix(int[,] matrixx)
{

    for (int i = 0; i < matrixx.GetLength(0); i++)
    {
        for (int j = 0; j < matrixx.GetLength(1); j++)

        {

            Console.Write(matrixx[i, j] + "\t  ");
        }
        Console.WriteLine();
    }


}
Console.Write("isizeput size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] myMat = SpiralMatrix(size);
ShowMatrix(myMat);