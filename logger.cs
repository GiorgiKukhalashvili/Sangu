/// This is a logger program.
/// This program takes an input and returns a log if input isn't empty.
///
/// @author Giorgi Kukhalashvili

using System;

public class Logger {
    public static void log() {
        /// Text input.
        Console.WriteLine("Text Input: ");
        string text = Console.ReadLine() ?? "0";

        /// While loop checks if user input is empty and returns another text input if true.
        while(string.IsNullOrEmpty(text)) {
            Console.WriteLine("Text Input: ");
            text = Console.ReadLine() ?? "0";
        }

        /// Console output.
        Console.WriteLine();
        Console.WriteLine($"Text Output: {text}");
    }
}