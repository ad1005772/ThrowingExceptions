using System;

class Program
{
    public string userInput;
    public string passInput;
    public static void Main(string[] args)
    {
        

        Console.WriteLine("Enter your username:");
        userInput = Console.ReadLine();
        Console.WriteLine("Enter your password:");
        passInput = Console.ReadLine();
        
       
        
    }

    public void TestUsername()
    {
        string username = "cat";
        if (userInput != username)
        {
            throw new InvalidUsernameException("Invalid Username");
        }
        
}
    public class InvalidUsernameException : System.Exception
    {
        public InvalidUsernameException(string message) : base(message)
        {
            
        }
    }

    public class InvalidPasswordException : System.Exception
    {
        public InvalidPasswordException(string message) : base(message)
        {
            
        }
    }
}
