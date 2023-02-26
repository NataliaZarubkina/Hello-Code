void FillArray(int[] collection) //метод заполняет массив. Void  - метод не возвращает значение
{
    int lenght = collection.Length;//находим длину массива collection
    int index = 0; //счетчик с нуля
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10); //заполняем массив рандомными числами от 1 до 10
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;//находим длину массива col
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);// выводит массив на экран
        position++;
    }
}

int Index0F(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;//из-за этого условия, если ввести число, которого нет в массиве, выведет позиция = 0, что неверно. Поэтому придумали выводить -1
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; //прерывание цикла при нахождении первого числа в массиве, которое = заданному
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //создать новый массив из 10 чисел

FillArray(array);

PrintArray(array);
Console.WriteLine();

int pos = Index0F(array, 444); //ввод числа ,которого нет в массиве
Console.WriteLine(pos);