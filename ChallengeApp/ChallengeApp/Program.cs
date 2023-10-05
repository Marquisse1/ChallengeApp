using ChallengeApp;

Employee employee1 = new Employee("Adam", "Adamski", 25);
Employee employee2 = new Employee("Bartek", "Bartkowski", 30);
Employee employee3 = new Employee("Cyprian", "Cypriański", 35);

//Task 1
employee1.AddPoints(5);
employee2.AddPoints(6);
employee3.AddPoints(7);
//Task  2
employee1.AddPoints(4);
employee2.AddPoints(9);
employee3.AddPoints(3);
//Task 3
employee1.AddPoints(7);
employee2.AddPoints(1);
employee3.AddPoints(8);
//Task  4
employee1.AddPoints(5);
employee2.AddPoints(6);
employee3.AddPoints(2);
//Task  5
employee1.AddPoints(3);
employee2.AddPoints(5);
employee3.AddPoints(5);

var employee1_score = employee1.Score;
var employee2_score = employee2.Score;
var employee3_score = employee3.Score;

if (employee1_score > employee2_score && employee1_score > employee3_score)
{
    int highest_score = employee1_score;
    Console.WriteLine("Najwyższą sumę ocen uzyskał " + employee1.Name + " " + employee1.Surname + " (lat " + employee1.Age + ") i wynosi ona " + highest_score + ".");
}
else if (employee2_score > employee3_score)
{
    int highest_score = employee2_score;
    Console.WriteLine("Najwyższą sumę ocen uzyskał " + employee2.Name + " " + employee2.Surname + " (lat " + employee2.Age + ") i wynosi ona " + highest_score + ".");
}
else if (employee3_score > employee2_score)
{
    int highest_score = employee3_score;
    Console.WriteLine("Najwyższą sumę ocen uzyskał " + employee3.Name + " " + employee3.Surname + " (lat " + employee3.Age +") i wynosi ona " + highest_score + ".");
}
