namespace PoliceDepartment.Core.Exceptions;

public class InvalidUsernameException : Exception
{
    public InvalidUsernameException(string message) 
        : base(message)
    {
        
    }
     
}