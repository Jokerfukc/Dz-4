Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum=0;
for (int i=99; i>=0; i--)
{
    sum+=number/(int)Math.Pow(10.0,i);
    number=number%(int)Math.Pow(10.0,i);
}
Console.WriteLine(sum);