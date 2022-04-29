int[,] array = new int[3, 3];
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

int[,] array1 = new int[3, 3];
Random rand = new Random();
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        array1[i, j] = rand.Next(1, 10);
        Console.Write(array1[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Clik enter"); 

int sum = 0;

for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        sum += array[i, j];

Console.ReadKey();

int sum1 = 0;

for (int i = 0; i < array1.GetLength(0); i++)
    for (int j = 0; j < array1.GetLength(1); j++)
        sum1 += array1[i, j];

Console.ReadKey();

int sumArray = 0;
sumArray += sum + sum1;
Console.WriteLine("Sum massiv: {0}",sumArray);