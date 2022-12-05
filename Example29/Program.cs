Console.Clear();
Console.Write("Enter lenght array: ");
int length = int.Parse(Console.ReadLine());
int[] collection = new int[length];

PrintArray(FillArray(collection));

int[] FillArray(int[] colA)
{
    int pos = 0;
    int rank = 1;
    while(pos < colA.Length)
    {
        Console.Write($"Enter {rank} number in array: ");
        colA[pos] = int.Parse(Console.ReadLine());
        pos++;
        rank++;
    }
    return colA;
}

void PrintArray(int[] arr)
{
    int index = 0; 
    while( index < arr.Length)
    {
        Console.WriteLine(arr[index]);
        index++;
    }
}
