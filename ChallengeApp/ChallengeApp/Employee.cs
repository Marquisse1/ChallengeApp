namespace ChallengeApp
{
    public class Employee
    {
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Score
        {
            get
            {
                return this.points.Sum();
            }
        }

        private List<int> points = new List<int>();

        public void AddPoints(int number)
        {
            this.points.Add(number);
        }

        public void SubPoints(int number)
        {
            this.points.Add(-number);
        }  
    }
}
