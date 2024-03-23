namespace APBD_2.Exceptions;

public class NotSameProductLoadedException : SystemException
{
        public NotSameProductLoadedException()
        {
        }

        public NotSameProductLoadedException(string message)
            : base(message)
        {
        }

        public NotSameProductLoadedException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
}