// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
//456 -> 5
//782 -> 8
//918 -> 1

int vvodint ()
{
    Console.WriteLine("Введите трехзначное число");
    string numberString = Console.ReadLine ();
    int number = Convert.ToInt32(numberString) ;
    return number;
}
int secondNumber (int number)
{
    int result = (number- number/100*100)/10;
     return result;
}
 
Console.WriteLine (secondNumber (vvodint ()));