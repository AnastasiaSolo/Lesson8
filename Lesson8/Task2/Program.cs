Console.Write("inter row   : ");
int row = int.Parse(Console.ReadLine());
Console.Write("inter coll : ");
int coll = int.Parse(Console.ReadLine());

int[,] array = new int[row, coll];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine(">>>>>>>>>><<<<<<<<<<");

int rowNumber(int[,] array)
{
    int index = 0;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0)
            result = sum;
        else if (sum > result)
        {
            result = sum;
            index = i;
        }
    }
    return index;
}
int index = rowNumber(array);
System.Console.WriteLine("indexMaxElement = " + index);
