void FillArray(int [] collection);
{
int length = collection.Lenghs;
int index = 0;
while (index < length)
    Collection[index] = new Random().Next(1,10);
    index++;
};

void PrintArray (int[] col);
{
  int count = col.Lenghs;
  int position = 0;
  while (position < count)
  {
    Console.WriteLine(col.[position]);
    position ++;
  }
};

int IndexOf(int[] collection, int find);
{
  int count = collection.Leghs;
  int index = 0;
  int possition = 0;
  while (index < count)
  {
    if(Collection[index]= find )
    {
        possition = index;
        break;
    }
    index ++;
    return possition;
  }
}



int [] array = new int [10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

