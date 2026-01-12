string[] inputs = Console.ReadLine().Split(' ');
var (n, m, a) = (long.Parse(inputs[0]), long.Parse(inputs[1]), long.Parse(inputs[2]));

long x = (n % a == 0) ? (n / a) : (n / a + 1);
long y = (m % a == 0) ? (m / a) : (m / a + 1);

Console.WriteLine(x * y);