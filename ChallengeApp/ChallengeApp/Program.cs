var name = "Damian";
var age = 29;
var sex = "male";

if (sex == "male" && age < 29)
{
    Console.WriteLine("Mezczyzna poniżej 29 lat");
}
else if (name == "Damian" && age == 29)
{
    Console.WriteLine("Damian, lat 29");
}
else if (sex == "male" && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
