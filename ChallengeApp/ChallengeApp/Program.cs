User user1 = new User("Adam", "123456");
User user2 = new User("Zuzia", "123456");
User user3 = new User("Marek", "hasło");
User user4 = new User("Stefan", "123456");

user1.AddScore(5);
user1.AddScore(7);
user1.AddScore(2);
Console.WriteLine(user1.score);
class User
{
    public int score { get; private set; }
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
        this.score = 0;
    }
    public string Login { get; private set; }
    public string Password { get; set; }

    public void AddScore(int number)
    {
        this.score += number;
    }
}