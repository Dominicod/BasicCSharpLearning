using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var splitNumber = phoneNumber.Split("-");
        return (splitNumber[0] == "212" ? true : false, splitNumber[1] == "555" ? true : false, splitNumber[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
