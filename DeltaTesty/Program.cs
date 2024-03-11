// See https://aka.ms/new-console-template for more information
using DeltaTesty;

Console.WriteLine("Hello, World!");

Delta delta = new Delta();
int a = 1; int b = 5; int c = 5;

var d = delta.GetDelta(a, b, c);
var checkDelta = delta.CheckDelta(d);
if (checkDelta == false)
{
    Console.WriteLine(delta.GetX0(a, b));
}
else
{
    if (checkDelta == true)
    {
        Console.WriteLine(delta.GetX1(a, b, d));
        Console.WriteLine(delta.GetX2(a, b, d));
    }
    else
    {
        Console.WriteLine("Brak miejsc zerowych");
    }
}