var name = "Damian";
var age = 29;
var sex = "mezczyzna";

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "mezczyzna" && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
