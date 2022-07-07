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
int[] A = new int[3];
int[] B = new int[3];
Console.WriteLine("Заполните координаты (x,y,z) точки А");
enterNumber(A);
Console.WriteLine("Заполните координаты (x,y,z) точки B");
enterNumber(B);
double distance = Math.Sqrt(Math.Pow(A[0]-B[0],2) + Math.Pow(A[1]-B[1],2) + Math.Pow(A[2]-B[2],2));
Console.WriteLine(distance);
