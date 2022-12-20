// Напишите программу,которая на вход принимает два числа 
// и выдает какое число большее, а какое меньшее
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number1>=number2)
{
    Console.WriteLine($"max = {number1}");
}
else
{
    Console.WriteLine($"max = {number2}");
}
