namespace Anthera.API.Service
{
    public interface IPasswordHasher
    {
        public string HashPassword(string password);
        public bool VerfilyPassword(string password, string hashedPassword);
    }
}
