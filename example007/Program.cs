Console.WriteLine ("Enter one numbers");
int a = int.Parse(Console.ReadLine());
Console.WriteLine ("Enter two numbers");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
  int max=a;
  int min=b;
   Console.Write("max numbers-");
   Console.WriteLine(max);
   Console.Write("min numbers-");
   Console.WriteLine(min);
} 
else if (a < b)
{
  int max=b;
  int min=a;
   Console.Write("max numbers-");
   Console.WriteLine(max);
   Console.Write("min numbers-");
   Console.WriteLine(min);
}
else
{
    Console.WriteLine("both numbers are equal");
}
