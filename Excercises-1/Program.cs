
internal class Excercises_B2
{
    static void Main()
    {
        Ex01();
        Ex02();
        Ex03();
        Ex04();
        Ex05();
        Ex06();
        Ex07();
        Ex08();
        Ex09();
        Ex10();
    }
    /// <summary>
    /// 1.to Add / Sum Two Numbers.
    /// </summary>
    static void Ex01()
    {
        int a = 2, b = 4;
        int c = a + b;
        Console.WriteLine($"{a} + {b} = {c}");
    }
    /// <summary>
    /// 2. to Swap Values of Two Variables.
    /// </summary>
    static void Ex02()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int a = 2, b = 4;
        int c = a;  // Store the value of a in c
        Console.Write("Số ban đầu: ");
        Console.WriteLine($"a = {a}, b = {b}");  // Corrected string interpolation here
        a = b;      // Assign the value of b to a
        b = c;      // Assign the original value of a (stored in c) to b
        Console.WriteLine("Số lúc sau:");
        Console.WriteLine($"a = {a}, b = {b}");  // Corrected string interpolation here
    }
    /// <summary>
    /// 3. to Multiply two Floating Point Numbers
    /// </summary>
    static void Ex03()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        float a = 1.5f, b = 4.4f;
        float c = a * b;
        Console.WriteLine("Số", c);
    }
    /// <summary>
    /// 4. to convert feet to meter
    /// </summary>
    static void Ex04()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập số feet:");
        double number = Convert.ToDouble(Console.ReadLine());
        double result = number * 0.3048;
        Console.WriteLine($"Số mét: {result}");
    }
    /// <summary>
    /// 5. to convert Celsius to Fahrenheit and vice versa
    /// </summary>
    static void Ex05()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Convert Celsius to Fahrenheit
        Console.WriteLine("Mời nhập vào độ C");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = a * 1.8 + 32;
        Console.WriteLine($"Độ F là: {b}");

        // Convert Fahrenheit to Celsius
        Console.WriteLine("Mời nhập vào độ F");
        double c = Convert.ToDouble(Console.ReadLine());
        double d = (c - 32) / 1.8;
        Console.WriteLine($"Độ C là: {d}");
    }
    /// <summary>
    /// 6. to find the Size of data types
    /// </summary>
    static void Ex06()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("6. Size of basic data types:");
        Console.WriteLine($"int: {sizeof(int)} bytes");
        Console.WriteLine($"float: {sizeof(float)} bytes");
        Console.WriteLine($"double: {sizeof(double)} bytes");
        Console.WriteLine($"char: {sizeof(char)} bytes");
        Console.WriteLine($"bool: {sizeof(bool)} byte");
        Console.WriteLine($"byte: {sizeof(byte)} byte");
        Console.WriteLine($"long: {sizeof(long)} bytes");
        Console.WriteLine($"decimal: {sizeof(decimal)} bytes");
        Console.WriteLine($"uint: {sizeof(uint)} bytes");
        Console.WriteLine($"short: {sizeof(short)} bytes");
    }
    /// <summary>
    /// 7. to Print ASCII Value (tip: read character, print number of this char)
    /// </summary>
    static void Ex07()
    {
        Console.Write("Enter a character: ");
        char ch = Convert.ToChar(Console.ReadLine());
        int asciiValue = (int)ch;
        Console.WriteLine($"ASCII value of '{ch}' is {asciiValue}");
    }
    /// <summary>
    /// 8. to Calculate Area of Circle
    /// </summary>
    static void Ex08()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        const double PI = (double)3.14;
        Console.WriteLine("Nhập bán kính hình tròn: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double area = PI * x * x;
        Console.WriteLine($"Diện tích hình tròn là: {area}");
    }
    /// <summary>
    /// 9. to Calculate Area of Square
    /// </summary>
    static void Ex09()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập cạnh của hình vuông:");
        double side = Convert.ToDouble(Console.ReadLine());
        double area = side * side;
        Console.WriteLine($"Diện tích hình vuông là: {area}");
    }
    /// <summary>
    /// 10. to convert days to years, weeks and days
    /// </summary>
    static void Ex10()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số ngày: ");
        int TotalDays = Convert.ToInt32(Console.ReadLine());

        int Năm = TotalDays / 365;                // 1 năm = 365 ngày
        int IntYear = TotalDays % 365;

        int Tuần = IntYear / 7;    // 1 tuần = 7 ngày
        int Ngày = IntYear % 7;

        Console.WriteLine($"Năm {Năm},Tuần {Tuần}, Ngày {Ngày}");
    }
}





























