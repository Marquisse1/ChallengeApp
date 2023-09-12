User user1 = new User("Adam", "123456");
User user2 = new User("Zuzia", "123456");
User user3 = new User("Marek", "hasło");
User user4 = new User("Stefan", "123456");

user1.AddScore(5);
user1.AddScore(7);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
class User
{
    private List<int> score = new List<int>();
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }
    public string Login { get; private set; }
    public string Password { get; set; }
    public int Result 
    {
        get
        {
            return this.score.Sum();
        } 
    }

    public void AddScore(int number)
    {
        this.score.Add(number);
    }
}