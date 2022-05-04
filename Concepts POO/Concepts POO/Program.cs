// See https://aka.ms/new-console-template for more information
using ConceptsOOP;

Console.WriteLine("OOP Concepts");
Console.WriteLine("*************");

try
{
    Console.WriteLine(new Date(2022, 12, 5));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 12, 21));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
