bool result = int.TryParse(Console.ReadLine(), out int number);
if (!result) throw new FormatException("The input is not a valid integer.");
Console.WriteLine((number > 2 && number % 2 == 0) ? "YES" : "NO");