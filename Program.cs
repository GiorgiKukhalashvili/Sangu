/*  This is a logger program.
    This program takes an input and returns a log if input isn't empty.

    @author Giorgi Kukhalashvili */

public class Program {
    public static void Main(string[] args) {
        // Variables for the main function
        string userInput = Logger.logInput();
        string trace = Logger.logTrace();
        string debug = Logger.logDebug();
        string info = Logger.logInfo();
        string error = Logger.logError();

        string path = "log.txt";
        string logText = "- user input: " + userInput;

        bool errorBool = false;

        // Error exception
        if(userInput == "error") {
            errorBool = true;
        }

        // Console output
        Console.WriteLine("- user output: ");
        Console.WriteLine(userInput);

        // Logging
        File.AppendAllText(path, trace + Environment.NewLine); // Trace

        File.AppendAllText(path, logText + Environment.NewLine); // Log input

        // Debug message checks if input is empty
        if(String.IsNullOrEmpty(userInput)) {
            Console.WriteLine("- input is empty");
            File.AppendAllText(path, debug + Environment.NewLine);
        }

        File.AppendAllText(path, info + Environment.NewLine); // Info

        // error message
        if(errorBool) {
            Console.WriteLine("- error");
            File.AppendAllText(path, error + Environment.NewLine);
        }
        
    }
}
