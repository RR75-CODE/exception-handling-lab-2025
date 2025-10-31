using System;

public class PasswordComplexityException : Exception
{
    public PasswordComplexityException(string message) : base(message)
    {
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your password:");
        string password = Console.ReadLine();

        try
        {
            CheckPassword(password);
            Console.WriteLine("Password accepted.");
        }
        catch (PasswordComplexityException ex)
        {
            Console.WriteLine("Password Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }
    static void CheckPassword(string password)
    {
        if (password.Length < 8)
        {
            throw new PasswordComplexityException("Password must be at least 8 characters long.");
        }
    }
}


