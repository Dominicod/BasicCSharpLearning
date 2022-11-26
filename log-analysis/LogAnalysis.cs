using System;

public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string subString) => str.Split(subString)[1];

    public static string SubstringBetween(this string str, string arg1, string arg2) => str.Split(new[] { arg1, arg2 }, StringSplitOptions.None)[1];

    public static string Message(this string str) => SubstringAfter(str, ":").Trim();

    public static string LogLevel(this string str) => SubstringBetween(str, "[", "]");
}