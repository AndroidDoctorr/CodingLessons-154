public class Calculator
{
    // Add (integers)   (bonus: more than two!!)
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Add(int[] nums)
    {
        int sum = 0;
        foreach (int n in nums)
        {
            sum = sum + n;
        }
        return sum;
    }

    // Add (doubles)    (bonus: more than two!!)
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Add(double[] doubles)
    {
        return doubles.Sum();
    }

    // Divide (ints)

    // Divide (doubles)
    public double Divide(double a, double b)
    {
        return a / b;
    }

    // Square x
    public double Square(double x)
    {
        return x * x;
    }
    // Cube x
    public double Cube(double x)
    {
        return Math.Pow(x, 3);
    }

    // BONUS:
    // Pow(x, y) => Raise x to the power of y
    public int Pow(int x, int y)
    {
        int result = 1;

        for (int i = 1; i <= y; i++)
        {
            result = result * x;
        }

        return result;
    }


    // IsPrime(n) => return true or false
    public bool IsPrime(int n)
    {
        return false;
    }
}