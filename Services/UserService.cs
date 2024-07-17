namespace Security_NET;

public class UserService: IUserService
{
    List<User> users = new List<User>()
    {
        new User(){Email = "person1@gmail.com", Password = "12345"},
        new User(){Email = "person2@hotmail.com", Password = "12345"}
    };

    public bool IsUser(string email, string password) => users.Where(p => p.Email == email && p.Password == password).Count() > 0;
}
