using System;

public class Logger {
    /// Logs user input
    public static string logInput() {
        Console.WriteLine("- user input: ");
        string text = Console.ReadLine() ?? "0";

        return text;
    }

    /// Logs trace
    public static string logTrace() {
        string userAction = "- user action: ";
        string userActionType1 = "input";

        return userAction + userActionType1;
    }

    /// Logs debug
    public static string logDebug() {
        string debugLog = "- debug: ";
        string emptyInput = "user input is empty";

        return debugLog + emptyInput;
    }

    /// Logs info
    public static string logInfo() {
        string infoLog = "- info: ";
        string authorInfo = "author - Giorgi Kukhalashvili";

        return infoLog + authorInfo;
    }

    /// Logs error
    public static string logError() {
        string errorLog = "- error: ";
        
        return errorLog;
    }
}