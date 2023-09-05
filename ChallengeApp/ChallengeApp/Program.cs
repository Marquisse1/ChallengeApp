// Zadanie domowe, dzień 4

string name1 = "Ewa";
char sex1 = ('f');
int age1 = 33;

string name2 = "Marek";
char sex2 = ('m');
int age2 = 47;


if (sex1 == 'f' && age1 < 30)
{
    Console.WriteLine("Kobieta, poniżej 30 lat.");
}
else if (sex1 == 'f' && age1 >= 30)
{
    if (name1 == "Ewa" && age1 == 33)
    {
        Console.WriteLine("Ewa, lat 33.");
    }
    else
    {
        Console.WriteLine("Ta kobieta nie ma na imię Ewa, lub nie ma 33 lat.");
    }
}
else
{
    if (sex1 == 'm' && age1 < 18)
    {
        Console.WriteLine("To jest niepełnoletni mężczyzna.");
    }
    else
    {
        Console.WriteLine("To jest pełnoletni mężczyzna.");
    }
}


if (name2 == "Marek" && sex2 == 'm')
{
    Console.WriteLine("Ten mężczyzna ma na imię Marek.");
    if (age2 < 20)
    {
        Console.WriteLine("Marek jest nastolatkiem.");
    }
    else if (age2 < 50)
    {
        Console.WriteLine("Marek jest przed pięćdziesiątką.");
    }
    else
    {
        Console.WriteLine("Marek jest po pięćdziesiątce.");
    }
}
else
{
    Console.WriteLine("To jest kobieta, lub mężczyzna, ale nie o imieniu Marek.");
}