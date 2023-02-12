void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{matrix[i, j]} ");
            if(image [i, j] == 0) Console.Write($" ");
            else
            {
                 Console.Write($"+ ");
            }
    
        } 
        
    }
}

/*void PrintImage [mage (int [,] image)
{
   for (int i = 0; i < PrintImage.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
    }
   } 
   Console.WriteLine();
}

int [,] pic = new int[,];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
*/
int [,] pic = new int [23,25];
void FillImage(int row, int col)
{
   if(pic[row,col] == 0) 
   {
    pic [row, col] = 1;
    FillImage (row - 1, col);
    FillImage (row, col-1);
    FillImage (row + 1, col);
    FillImage (row, col+1);

   }
}


PrintImage(pic);
FillImage (13 , 13 );
PrintImage(pic);