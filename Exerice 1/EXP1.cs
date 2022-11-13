Console.WriteLine("Enter value a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter value b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter value c: ");
int c = int.Parse(Console.ReadLine());

int delta = b * b - (4 * a * c);

Console.WriteLine("Delta of the equation is {0}", delta);