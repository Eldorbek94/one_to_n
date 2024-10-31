Console.WriteLine("Programm Calculate one to N!");
Console.WriteLine("Enter a positive integer (N): ");
int n = Convert.ToInt32(Console.ReadLine());

int summ = (n * (n + 1)) / 2;

Console.WriteLine($"The sum from 1 to {n} is: {summ}");