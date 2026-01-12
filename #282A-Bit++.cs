bool result = int.TryParse(Console.ReadLine(), out int number);
if (!result) throw new FormatException("The input is not a valid integer.");

int count = 0;

for (int i = 0; i < number; i++)
{
    string value = Console.ReadLine();
    if (value.Contains('+')) count++;
    else count--;
}

Console.WriteLine(count);