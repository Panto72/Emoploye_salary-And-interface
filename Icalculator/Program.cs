using calculator;

public class Program
{
    public static void Main()
    {
        Calculate calculate = new Calculate();
        double Sum = calculate.Add(5,10);
        double Sub = calculate.Sub(5,10);
        double Div = calculate.Div(5,10);
        double Mul = calculate.Mul(5,10);
        Console.WriteLine(Sum);
        Console.WriteLine(Sub);
        Console.WriteLine(Div);
        Console.WriteLine(Mul);

    }
}