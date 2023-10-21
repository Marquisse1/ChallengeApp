using ChallengeApp;

//Tworzenie pracowników
Employee employee1 = new Employee("Adam", "Adamski", 25);
Employee employee2 = new Employee("Bartek", "Bartkowski", 30);
Employee employee3 = new Employee("Cyprian", "Cypriański", 35);

//Przydzielanie punktów
//Task 1
employee1.AddPoints(5);
employee2.AddPoints(6);
employee3.AddPoints(7);
employee1.SubPoints(10);
employee1.SubPoints(14);
//Task 2
employee1.AddPoints(4);
employee2.AddPoints(9);
employee3.AddPoints(3);
//Task 3
employee1.AddPoints(7);
employee2.AddPoints(1);
employee3.AddPoints(8);
//Task 4
employee1.AddPoints(5);
employee2.AddPoints(6);
employee3.AddPoints(2);
//Task  5
employee1.AddPoints(3);
employee2.AddPoints(5);
employee3.AddPoints(5);

//Tworzenie listy pracowników
List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

//Stworzenie zmiennej - maksymalny wynik
int maxResult = -1;

//Stworzenie kontenera, specjalnego użytkownika roboczego jako użytkownika z największą liczbą punktów
Employee userWithMaxResult = null;

//Pętla sprawdzająca po kolei każdego pracownika z listy czy ma najwyższy wynik
foreach (var employee in employees)
{
    if (employee.Score > maxResult)
    {
        userWithMaxResult = employee;
        maxResult = employee.Score;
    }
}

//Wyświetlenie wyniku
Console.WriteLine("Najwyższą sumę ocen uzyskał " + userWithMaxResult.Name + " " + userWithMaxResult.Surname + " (lat " + userWithMaxResult.Age + ") i wynosi ona " + maxResult + ".");
Console.WriteLine("Pracownik 1 - " + employee1.Name + " " + employee1.Surname + " uzyskał " + employee1.Score + " punktów.");
Console.WriteLine("Pracownik 2 - " + employee2.Name + " " + employee2.Surname + " uzyskał " + employee2.Score + " punktów.");
Console.WriteLine("Pracownik 3 - " + employee3.Name + " " + employee3.Surname + " uzyskał " + employee3.Score + " punktów.");