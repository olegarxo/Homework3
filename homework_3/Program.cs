Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());
int index = 1;
while(index <= numb)
{
    if (index <= (numb-1))
    {
    Console.Write($"{Math.Pow(index,3) }, ");
    }
    else
    {
        Console.Write($"{Math.Pow(index,3) }. ");
    }
    index++;
}
