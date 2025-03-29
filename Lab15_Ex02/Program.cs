using static System.Console;

WriteLine(Calculator.AddValues(2, 3));            // คำนวณ int + int
WriteLine(Calculator.AddValues(2.0f, 3.0f));      // คำนวณ float + float
WriteLine(Calculator.AddValues(2L, 3L));          // คำนวณ long + long

public static class Calculator
{
    // Method สำหรับการคำนวณ int + int
    public static int AddValues(int a, int b)
    {
        WriteLine("Calculated by method: public static int AddValues(int a, int b)");
        return a + b;
    }

    // Method สำหรับการคำนวณ float + float
    public static float AddValues(float f, float g)
    {
        WriteLine("Calculated by method: public static float AddValues(float f, float g)");
        return f + g;
    }

    // Method สำหรับการคำนวณ long + long
    public static long AddValues(long h, long i)
    {
        WriteLine("Calculated by method: public static long AddValues(long h, long i)");
        return h + i;
    }
}
