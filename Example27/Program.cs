Console.Clear();
Print("Enter Number: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[CountDigit(number)];

Console.Write(SumDigit(FromNumberToArray(array, number)));

int SumDigit(int[] collection)
{
    int sum = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        sum = sum + collection[i];
    }
    return sum;
}

void Print(string text)
{
    Console.Write(text);
}

int[] FromNumberToArray(int[] arr, int digit)
{
    int index = arr.Length-1;
    int[] array = arr;
    while(index >= 0)
    {
        array[index] = digit % 10;
        digit = digit / 10;
        index--;
    }
    return array;
}

int CountDigit(int number)
{
    int i = 0;
    while (number > 0)
    {
        number = number / 10;
        i++;
    }
    return i;
}