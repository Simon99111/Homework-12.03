public class Shares
{
    public static int Input(string msg)
    {
        Console.Write(msg + " ");
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int Decrease(int num)
    {
        int n = num;
        if (n == 0) return 1;
        else
        {
            Console.Write(n + " ");
            return n = Decrease(n - 1);
        }
    }
    public static int Summ(int num1, int num2)
    {
        if (num1 == num2) return num1;
        else return num1 + Summ(num1 + 1, num2);
    }
    public static int Acker(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return Acker(m - 1, 1);
        else if (n > 0) return Acker(m - 1, Acker(m, n - 1));
        return 0;
    }
}