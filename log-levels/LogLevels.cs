using System;
using System.Text.RegularExpressions;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(":")[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        return logLine.Split('[',']')[1].ToLower();
    }
    
    public static string Reformat(string logLine)
    {
        return Message(logLine) + $" ({LogLevel(logLine)})";
    }
}
