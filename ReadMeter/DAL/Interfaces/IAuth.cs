namespace DAL.Interfaces;

public interface IAuth
{
    bool Authenticate(string username, string password);
}