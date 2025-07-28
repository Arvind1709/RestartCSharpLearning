// See https://aka.ms/new-console-template for more information
using RestartCSharpLearning;

Console.WriteLine("Start Of Your Code!");
Console.WriteLine(" ");
try
{
    // Your code goes here
    Variables variables = new Variables();
    variables.Example();
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
Console.WriteLine(" ");
Console.WriteLine("End Of Your Code!");
Console.ReadLine();