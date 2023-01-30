//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int vvodint ()
{
    Console.WriteLine("Введите день недели числом от 1 до 7");
    string numberString = Console.ReadLine ();
    int number = Convert.ToInt32(numberString) ;
    return number;
}
void weekend (int number)
{
    if (number == 7)
    {
        Console.WriteLine ("да");
    }
    else 
    {
        if (number == 6)
        {
            Console.WriteLine ("да");
        }
        else
        {
             Console.WriteLine ("нет");
        }
    }
}
 
weekend(vvodint ());
