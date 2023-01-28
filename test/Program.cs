Console.WriteLine ("Enter tree numbers,please");
string[] arr= Console.ReadLine().Split();
 
int a = int.Parse(arr[0]);
int b = int.Parse(arr[1]);
int c = int.Parse(arr[2]);
int[] arrey = {1,2,3};
arrey[0] =(a);
arrey[1] =(b);
arrey[2] =(c);
int max=a;
if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;
Console.Write("max numbers-");
Console.WriteLine (max);
