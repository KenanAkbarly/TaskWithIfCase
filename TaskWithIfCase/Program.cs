
int score = int.Parse(Console.ReadLine());
if (score >=88 && score <= 100)
{
    Console.WriteLine($"Success-AA\nYour score:{score}");
}
else if (score >= 81 && score <= 87)
{
    Console.WriteLine($"Success-BA\nYour score:{score}");
}
else if (score >= 74 && score <= 80)
{
    Console.WriteLine($"Success-BB\nYour score:{score}");
}
else if (score >= 67 && score <= 73)
{
    Console.WriteLine($"Success-CB\nYour score:{score}");
}
else if (score >= 60 && score <= 66)
{
    Console.WriteLine($"Success-CC\nYour score:{score}");
}
else if (score >= 0 && score <= 59)
{
    Console.WriteLine($"Fail-FF\nYour score:{score}");
}
else
{
    Console.WriteLine("Invalid score");
}