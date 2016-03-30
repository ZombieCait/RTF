using System;

internal class ProgramException : SystemException
{
    public ProgramException(string message)
    {
        Console.WriteLine(message);
    }
}