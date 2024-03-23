namespace APBD_2.Exceptions;

public class WrongTemperatureException : System.Exception
{
    public WrongTemperatureException()
    {
    }

    public WrongTemperatureException(string message)
        : base(message)
    {
    }

    public WrongTemperatureException(string message, System.Exception inner)
        : base(message, inner)
    {
    }
}