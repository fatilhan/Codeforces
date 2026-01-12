bool result = int.TryParse(Console.ReadLine(), out int number);
if (!result) throw new FormatException("The input is not a valid integer.");

int count = 0;

for (int i = 0; i < number; i++)
{
    string[] solution = Console.ReadLine().Split(' ');
    if (solution.Count(x => x == "1") >= 2) count++;
}

Console.WriteLine(count);