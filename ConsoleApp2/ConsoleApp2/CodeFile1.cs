public delegate void MethodHandlerA();
public delegate int  MethodHandlerB(int x , int y);

public class MathCalculator
{
    public void DoTask()
    {
        Console.WriteLine("Calculator DoTask");
    }
    public int Add(int x, int y)
    {
        Console.WriteLine(x + "," + y);
        return x + y;
    }
    public int Multiply(int x, int y)
    {
        Console.WriteLine(x + "," + y);
        return x * y;
    }
    public double Divide(double x, double y)
    {
        Console.WriteLine();
        return x / y;
    }
    public String GetModel()
    {
        return "X500";
    }
}
public class DelegateDemo
{
    public static void TestOne()
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerA methodHandlerA = mc.DoTask;
        MethodHandlerB methodHandlerB = mc.Add;
        MethodHandlerB methodHandlerTwo =mc.Multiply;
        methodHandlerA();
        int addResult = methodHandlerB(100, 50);
        Console.WriteLine(addResult);
        int multiplyResult = methodHandlerTwo(20, 5);
        Console.WriteLine(multiplyResult);

    }
    public static void TestTwo()
    {
        MathCalculator mc = new MathCalculator ();
    }
}