namespace Security_NET;

public interface IUserService
{
    public bool IsUser(string email, string pass);
}
