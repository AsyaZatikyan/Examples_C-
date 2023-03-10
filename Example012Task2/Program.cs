/*
1. Найти позицию минимального элемента в неотсортированной части 
массива
2. Произвести обмен этого значения со значением первой 
неотсортированной позиции
3. Повторять пока есть не отсортированные элементы.
*/

int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 11 };

// пишем метод чтобы, вывести массив на экран,

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

// пишем метод, который будет упорядчивать наш массив;

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}
PrintArray(array);
SelectionSort(array);

PrintArray(array);