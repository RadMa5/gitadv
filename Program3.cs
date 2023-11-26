Console.Write("Enter the number : ");
string num = Console.ReadLine();
int numr = int.Parse(num);

int rem = numr % 2;

if (rem == 0 )
{
    Console.WriteLine($"{numr} is even");
}
else 
{
    Console.WriteLine($"{numr} is odd");
}
