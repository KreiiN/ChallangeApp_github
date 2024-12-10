var name = "Ewa";
string plec = "K";
var Age = 30;


if (plec == "K" && Age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && Age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if (plec == "M" && Age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Nie pasuje do programu");
}
