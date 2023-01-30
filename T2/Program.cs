//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6//

int vvodint ()
{
    Console.WriteLine("Введите число");
    string numberString = Console.ReadLine ();
    int number = Convert.ToInt32(numberString) ;
    return number;
}
int thirdNumber (int number)
{
    int count = 0;
    int result = number;
    int tNumber = -1;
    while (result>0)
    {
        count++;
        result = result/10;
    }
    if (count<3)
    {
        Console.WriteLine ("третьей цифры нет");
    }
    else 
    {
        result = number;
        count=count -3;
        while (count>0) 
        {
        result = result/10;
        count = count - 1;
        }
        tNumber = result%10;
    }
         return tNumber;
}
 
int final = (thirdNumber (vvodint ()));
if (final>=0)
{
    Console.WriteLine (final);
}
