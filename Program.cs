var button = 101;
var index = 1;
var falseFloor = 0;

while (index != button)
{
    if (index % 10 == 4)
    {
        falseFloor = falseFloor + 1;
    }
    if (index % 100 == 13)
    {
        falseFloor = falseFloor + 1;
    }
    index = index + 1;
}

if (button % 10 == 4 || button % 100 == 13)
{
    Console.WriteLine("kan ej omvandla till riktigt våningsnummer");
}
else
{
    Console.WriteLine(button - falseFloor);
}