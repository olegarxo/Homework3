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
string comparisonNumber(int[] firstMassive,int[] secondMassive)
{
    int index = 0;
    int length = firstMassive.Length;
    string text = "да";
    while(index<(length/2))
    {    
        if(firstMassive[index]==secondMassive[length-(1+index)])
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
Console.WriteLine("Введите последовательность из 5 чисел");
int[] massive = new int[5];
enterNumber(massive);
Console.WriteLine();
int[] newMassive = new int[5];
newMassive = massive;
rebootNumber(newMassive);
string text = string.Empty;
text = comparisonNumber(massive,newMassive);
Console.WriteLine(text);