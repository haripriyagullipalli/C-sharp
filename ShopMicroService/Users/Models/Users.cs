public class Users
{
    private readonly List<UserInfo> _users;

    public Users()
    {
        _users = new List<UserInfo>();
    }
    
    public List<UserInfo> GetUsers() => _users;
    
    public void AddUser(UserInfo user) => _users.Add(user);
}

public class UserInfo
{
    public string name { get; set; }
    public string gmail { get; set; }
}