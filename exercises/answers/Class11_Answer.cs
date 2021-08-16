
/*
 * Q1 : ABC
 */
 
// Q2

// Q3
class Program
{
    public static void Q3()
    {
        Console.WriteLine("f1's root at x = {0}", FindRoot(F1, 1, 4, 0.0001));
        Console.WriteLine("f2's root at x = {0}", FindRoot(F2, 0, 2, 0.0001));
        Console.WriteLine("f3's root at x = {0}", FindRoot(F3, -2, 4, 0.0001));
        Console.WriteLine("f4's root at x = {0}", FindRoot(F4, 1, 2, 0.0001));
        Console.WriteLine("f5's root at x = {0}", FindRoot(F5, 3, 4, 0.0001));
    }
    static double FindRoot (Func<double,double> F, double lowerBound, double upperBound, double maxErr)
    {
        double a = new double(), b = new double(), c = new double();
        do
        {
            Random rnd = new Random();
            a = rnd.NextDouble() * (upperBound - lowerBound) + lowerBound;
            b = rnd.NextDouble() * (upperBound - lowerBound) + lowerBound;
        }while (F(a)*F(b) > 0);

        while (Math.Abs(a-b) > maxErr)
        {
            c = (a+b) / 2;
            if (F(a)*F(c) > 0) { a = c; }
            else { b = c; }
        }
        return c;
    }

    static double F1(double x)
    {
        return x*x - x - 2;
    }
    static double F2(double x)
    {
        return x*x*x - 2;
    }
    static double F3(double x)
    {
        return x*Math.Cos(x) + 1;
    }
    static double F4(double x)
    {
        return x*x + Math.Exp(x/2) - 5;
    }
    static double F5(double x)
    {
        return Math.Sin(x)*Math.Sinh(x) + 1;
    }
}
