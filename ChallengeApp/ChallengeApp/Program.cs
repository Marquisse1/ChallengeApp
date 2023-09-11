User user1 = new User("Adam", "123456");
User user2 = new User("Zuzia", "123456");
User user3 = new User("Marek", "hasło");
User user4 = new User("Stefan", "123456");

var name = user1.Login;
Console.WriteLine(name);
class User
{
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }
    public string Login { get; private set; }
    public string Password { get; set; }

}