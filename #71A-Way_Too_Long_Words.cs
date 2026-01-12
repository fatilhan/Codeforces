bool result = int.TryParse(Console.ReadLine(), out int number);
if (!result) throw new FormatException("The input is not a valid integer.");

for (int i = 0; i < number; i++)
{
    string word = Console.ReadLine();

    if (word.Length > 10)
        word = $"{word[0]}{word.Length - 2}{word[^1]}";

    Console.WriteLine(word);
}