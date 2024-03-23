namespace APBD_2.Exceptions;

public class NoSuchProductException : SystemException
{
    public NoSuchProductException()
    {
    }

    public NoSuchProductException(string message)
        : base(message)
    {
    }

    public NoSuchProductException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
}