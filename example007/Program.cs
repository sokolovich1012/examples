Console.WriteLine ("Enter one numbers");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine ("Enter two numbers");
int numB = int.Parse(Console.ReadLine());
if (numA > numB)
{
    Console.WriteLine("one numbers is max");
} 
else if (numA < numB)
{
  Console.WriteLine("two numbers is max")  ;
}
else
{
    Console.WriteLine("both numbers are equal");
}
