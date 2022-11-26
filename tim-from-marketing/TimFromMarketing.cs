using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        return id == null ? $"{name} - {(department ?? "OWNER").ToUpper()}" : $"[{id}] - {name} - {(department ?? "OWNER").ToUpper()}";
    }
}
