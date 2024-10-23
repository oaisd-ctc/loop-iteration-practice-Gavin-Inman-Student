public class Program
{
    public static void Main()
    {
        Write1ThroughN_While(-1);
        Write1ThroughN_For(22);
        WriteNThrough1_While(22);
        WriteNThrough1_For(22);
        WriteEvensThrough100();
        FindSum(100);
        FindSumOfEvenNumbers(4);
        FindSumOfOddNumbers(4);
        OutputRightTriangle(4);
    }
    public static void Write1ThroughN_While(int n)
    {
        if (n >= 1)
        {
        int i = 1;
        while (n >= i)
        {
            Console.WriteLine(i);
            i++;
        }
        }
        else
        {
            OutOfRangeMessage(n);
        }
    }
    public static void Write1ThroughN_For(int n)
    {
        if (n >= 1)
        {
        for (int i = 1; n >= i; i++)
        {
            Console.WriteLine(i);
        }
        }
        else
        {
            OutOfRangeMessage(n);
        }        
    }
    public static void WriteNThrough1_While(int n)
    {
        if (n >= 1)
        {
        int i = n;
        while (i >= 1)
        {
            Console.WriteLine(i);
            i--;
        }
        }
        else
        {
            OutOfRangeMessage(n);
        }
    }
    public static void WriteNThrough1_For(int n)
    {
        if (n >= 1)
        {
        for (int i = n; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        }
        else
        {
            OutOfRangeMessage(n);
        }        
    }
    public static void WriteEvensThrough100()
    {
        int i = 2;
        while(i <= 100)
        {
            Console.WriteLine(i);
            i++;
            i++;
        }
    }
    public static void FindSum(int n)
    {
        if (n >= 1)
        {
        int sum = 0;
        int i = 0;
        while (i <= n)
        {
            sum = sum + i;
            i = i + 1;

        }
        Console.WriteLine(sum);
        }
        else
        {
            OutOfRangeMessage(n);
        }        
    }
    public static void FindSumOfEvenNumbers(int n)
    {
        if (n >= 1)
        {
        int sum = 0;
        for (int i = 2; i <= n;)
        {
            sum = sum + i;
            i = i + 2;
        }
        Console.WriteLine(sum);
        }
        else
        {
            OutOfRangeMessage(n);
        }        
    }
    public static void FindSumOfOddNumbers(int n)
    {
        if (n >= 1)
        {
        int sum = 0;
        for (int i =1; i <= n;)
        {
            sum = sum + i;
            i = i + 2;
        }
        Console.WriteLine(sum);
        }
        else
        {
            OutOfRangeMessage(n);
        }        
    }
    public static void OutputRightTriangle(int _base)
    {
        if (_base > 0)
        {
            for (int i = 0; i < _base; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("+");
            }
            Console.WriteLine("");
        }
        }
        else if (_base < 0)
        {
            for (int i = 0; i > _base; i--)
        {
            for (int j = _base; j < i; j++)
            {
                Console.Write("+");
            }
            Console.WriteLine("");
        }
        }
        else
        {
            OutOfRangeMessage(_base);
        }
    }
    public static void OutOfRangeMessage(int n)
    {
        Console.WriteLine($"{n} is out of range");
    }
}
