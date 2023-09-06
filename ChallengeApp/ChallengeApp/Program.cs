//Zadanie domowe dzień 5

int number = 255478;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
//int[] result = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
int[] result = new int[10];

Console.WriteLine("Wyniki dla liczby: " + number);
foreach (char letter in letters)
{
    if (letter == '0')
    {
        result[0] = result[0] + 1;
    }
    else if (letter == '1')
    {
        result[1] = result[1] + 1;
    }
    else if (letter == '2')
    {
        result[2] = result[2] + 1;
    }
    else if (letter == '3')
    {
        result[3] = result[3] + 1;
    }
    else if (letter == '4')
    {
        result[4] = result[4] + 1;
    }
    else if (letter == '5')
    {
        result[5] = result[5] + 1;
    }
    else if (letter == '6')
    {
        result[6] = result[6] + 1;
    }
    else if (letter == '7')
    {
        result[7] = result[7] + 1;
    }
    else if (letter == '8')
    {
        result[8] = result[8] + 1;
    }
    else if (letter == '9')
    {
        result[9] = result[9] + 1;
    }
}

Console.WriteLine("0 => " + result[0]);
Console.WriteLine("1 => " + result[1]);
Console.WriteLine("2 => " + result[2]);
Console.WriteLine("3 => " + result[3]);
Console.WriteLine("4 => " + result[4]);
Console.WriteLine("5 => " + result[5]);
Console.WriteLine("6 => " + result[6]);
Console.WriteLine("7 => " + result[7]);
Console.WriteLine("8 => " + result[8]);
Console.WriteLine("9 => " + result[9]);

Console.ReadLine();
