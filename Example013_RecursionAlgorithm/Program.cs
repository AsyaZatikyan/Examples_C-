string[,] table = new string[2, 5];
// String. Empty
// table[0,o] table[0,1] table [0,2]
// table[1,01 table[1,1] table [1,2]
/* 
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
   for (int  columen = 0; columen < 5; columen++)
   {
    Console.WriteLine($"{table [rows,columen]}--");
   } 
}*/

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
    }
   } 
   Console.WriteLine();
}

int[,] matrix = new int[3, 4];8
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
