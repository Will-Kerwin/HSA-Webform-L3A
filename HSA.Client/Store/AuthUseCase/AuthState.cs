namespace HSA.Client.Store.AuthUseCase
{
    public class AuthState
    {
        public AuthState(Guid iD, string firstName, bool isAuthenticated, string lastName, string trade, DateTime dateOfBirth, string role)
        {
            ID = iD;
            FirstName = firstName;
            IsAuthenticated = isAuthenticated;
            LastName = lastName;
            Trade = trade;
            DateOfBirth = dateOfBirth;
            Role = role;
        }

        public Guid ID { get; }
        public string FirstName { get; }
        public bool IsAuthenticated { get; }
        public string LastName { get; }
        public string Trade { get; }
        public DateTime DateOfBirth { get; }
        public string Role { get; }
    }
}
