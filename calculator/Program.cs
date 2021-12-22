using System.Text.RegularExpressions;

public class Calculator { 

    public static void Main(string[] args) {
        while (true) {
            Console.WriteLine("Welcome to calculator! Enter operation");
            Console.WriteLine("1 Addition");
            Console.WriteLine("2 Subtraction");
            Console.WriteLine("3 Division");
            Console.WriteLine("4 Multiplication");
            Console.WriteLine("5 Exit");
            try
            {
                String inpt = Console.ReadLine();
                int input = Int32.Parse(inpt);
                if (input == 1)
                {
                    try
                    {
                        Console.WriteLine("Enter first number");
                        String s1 = Console.ReadLine();
                        if (Regex.IsMatch(s1, @"^\d+$"))
                        {
                            int n1 = Int32.Parse(inpt);
                            Console.WriteLine("Enter second number");
                            String s2 = Console.ReadLine();
                            if (Regex.IsMatch(s2, @"^\d+$"))
                            {
                                int n2 = Int32.Parse(inpt);
                                Console.WriteLine("Result: " + Addition(n1, n2));
                            } 
                        }
                        Console.WriteLine("Invalid Input");

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                else if (input == 2)
                {
                    try
                    {
                        Console.WriteLine("Enter first number");
                        String s1 = Console.ReadLine();
                        if (Regex.IsMatch(s1, @"^\d+$"))
                        {
                            int n1 = Int32.Parse(inpt);
                            Console.WriteLine("Enter second number");
                            String s2 = Console.ReadLine();
                            if (Regex.IsMatch(s2, @"^\d+$"))
                            {
                                int n2 = Int32.Parse(inpt);
                                Console.WriteLine("Result: " + Subtraction(n1, n2));
                            }
                        }
                        Console.WriteLine("Invalid Input");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                else if (input == 3)
                {
                    try
                    {
                        Console.WriteLine("Enter first number");
                        String s1 = Console.ReadLine();
                        if (Regex.IsMatch(s1, @"^\d+$"))
                        {
                            int n1 = Int32.Parse(inpt);
                            Console.WriteLine("Enter second number");
                            String s2 = Console.ReadLine();
                            if (Regex.IsMatch(s2, @"^\d+$"))
                            {
                                int n2 = Int32.Parse(inpt);
                                Console.WriteLine("Result: " + Division(n1, n2));
                            }
                        }
                        Console.WriteLine("Invalid Input");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                else if (input == 4)
                {
                    try
                    {
                        Console.WriteLine("Enter first number");
                        String s1 = Console.ReadLine();
                        if (Regex.IsMatch(s1, @"^\d+$"))
                        {
                            int n1 = Int32.Parse(inpt);
                            Console.WriteLine("Enter second number");
                            String s2 = Console.ReadLine();
                            if (Regex.IsMatch(s2, @"^\d+$"))
                            {
                                int n2 = Int32.Parse(inpt);
                                Console.WriteLine("Result: " + Multiplication(n1, n2));
                            }
                        }
                        Console.WriteLine("Invalid Input");
                    }
                    catch (FormatException ex) {
                        Console.WriteLine("Invalid Input"); 
                            }
                }
                else if (input == 5)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Invalid input");
            };

        }

        

    }
    public static double Addition(double a, double b)
    {
        double result = 0;
        result = a + b;
        return result;
    }
    public static double[] Addition(double[] a, double[] b)
    {
        double[] result = new double[a.Length];
        for (int i = 0; i < a.Length; i++) {
            result[i] = a[i] + b[i];
        }
        return result;
    }
    public static double[] Addition(double[] a, double b)
    {
        double[] result = new double[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] + b;
        }
        return result;
    }
    public static double Subtraction(double a, double b)
    {
        double result = 0;
        result = a - b;
        return result;
    }
    public static double[] Subtraction(double[] a, double[] b)
    {
        double[] result = new double[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] - b[i];
        }
        return result;
    }
    public static double[] Subtraction(double[] a, double b)
    {
        double[] result = new double[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i] - b;
        }
        return result;
    }
    public static double[] Subtraction(double a, double[] b)
    {
        double[] result = new double[b.Length];
        for (int i = 0; i < b.Length; i++)
        {
            result[i] = a - b[i];
        }
        return result;
    }
    public static double Division(double a, double b)
    {
        double result = 0;
        if (b == 0)
        {
            Console.WriteLine("NaN: Not a Number");
            return double.NaN;
            Console.WriteLine("NaN: Not a Number");
        }
        result = a / b;
        return result;
    }
    public static double Multiplication(double a, double b)
    {
        double result = 0;
        result = a * b;
        return result;
    }
}