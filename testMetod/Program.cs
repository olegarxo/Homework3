void enterNumber(int[] sumMassive)
{
    int index = 0;
    int length = sumMassive.Length;

    while(index < length)
    {
        sumMassive[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}
void randomBumber (int[] sumMassive)
{
    int index=0;
    int length = sumMassive.Length;
    while(index<length)
    {
        sumMassive[index] = new Random().Next(1,10);
        index++;
    }
}
void rebootNumber(int[] sumMassive)
{
    int index = 0;
    int length = sumMassive.Length;
    int tamp = 0;
    while(index<length/2)
    {
        tamp = sumMassive[index];
        sumMassive[index] = sumMassive[length-(1+index)];
        sumMassive[length-(1+index)] = tamp;
        index++;
    }
    

}
void printNumber(int[] sumMassive)
{
    int length = sumMassive.Length;
    int index = 0;
    while(index<length)
    {
        Console.WriteLine(sumMassive[index]);
        index++;
    }
}
string comparisonNumber(int[] firstMassive,int[] secondMassive)
{
    int index = 0;
    int length = firstMassive.Length;
    string text = "да";
    while(index<(length/2))
    {    
        if(firstMassive[index]==secondMassive[length-1])
        {
            index++;
            text = "да";
        }
        else
        {
            text = "нет";
            break; 
        }
    }
    return text;
}
int findNubmer(int[] sumMassive,int number)
{
    int index = 0;
    int length = sumMassive.Length;
    int position = 0;
    while(index<length)
    {
        if (sumMassive[index] == number);
        {
            position = index; 
            break;
        }
    }
    return position;
}
int[] number = new int [5];
randomBumber(number);
printNumber(number);
int[] newNumber = new int[5];
newNumber = number;
rebootNumber(newNumber);
Console.WriteLine();
printNumber(newNumber);
string text = comparisonNumber(number, newNumber);
