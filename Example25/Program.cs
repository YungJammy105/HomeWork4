Console.Clear();
Console.Write("Enter number A: ");
bool intA = int.TryParse(Console.ReadLine(), out int numA);
Console.Write("Enter number B: ");
bool intB = int.TryParse(Console.ReadLine(), out int numB);
if(!(intA & intB))
{
    Console.WriteLine("Entered incorrect data");
}
else
{
    Console.WriteLine(PowerOfNumber(numA,numB));
}


int PowerOfNumber(int number, int power)
{
    int result = number;
    for(int i = 1; i < power; i++)
    {
        
        result = result * number;
    }
    return result;
}