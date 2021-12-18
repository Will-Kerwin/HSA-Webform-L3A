namespace HSA.Server.Exceptions.Auth
{
    public class IncorrectPasswordException : Exception
    {
        public IncorrectPasswordException(string message) : base(message)
        {
        }
    }
}
