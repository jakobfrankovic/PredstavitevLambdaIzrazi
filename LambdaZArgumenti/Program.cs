// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;


[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class ExampleAttribute : Attribute
{
    public string Description { get; }

    public ExampleAttribute(string description)
    {
        Description = description;
    }
}

class Program
{
    static void Main()
    {
        Func<string, string> addExclamation = [Example("Doda klicaj")] (string message) =>
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));
            return message + "!";
        };

        // Using the lambda function
        string result = addExclamation("Hello");
        Console.WriteLine(result); // Outputs: Hello!
    }
}