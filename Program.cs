using System;

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Text Input: ");
        string text = Console.ReadLine() ?? "0";

        while(string.IsNullOrEmpty(text)) {
            Console.WriteLine("Text Input: ");
            text = Console.ReadLine() ?? "0";
        }

        Console.WriteLine();
        Console.WriteLine($"Text Output: {text}");
    }
}