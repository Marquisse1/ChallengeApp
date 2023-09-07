User user1 = new User();
User user2 = new User("Zuzia");
User user3 = new User("Marek", "hasło");
User user4 = new User();

class User
{
    private string login;
    private string password;
    private string name;

    public User()
    {
        this.login = "-";
        this.password = "-";
        this.name = "-";
    }

    public User(string login)
    {
        this.login = login;
        this.password = "-";
        this.name = "-";
    }

    public User(string login, string password)
    {
        this.login = login;
        this.password = password;
        this.name = "-";
    }
    public User(string login, string password, string name)
    {
        this.login = login;
        this.password = password;
        this.name = name;
    }

}