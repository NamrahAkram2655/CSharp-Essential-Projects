using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter First Value : ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Second Value : ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter any operator + - x /");
        String op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine("Output " +(num1+num2) );
                break;
            case "-":
                Console.WriteLine("Output " + (num1 - num2));
                break;
            case "*":
            case "x":
                Console.WriteLine("Output " + (num1 * num2));
                break;
            case "/":
               
                    if(num2>num1)
                    {

                    double res = num1 / num2;
                    Console.WriteLine("Output ", +res);
                    }
                
                else 
                {
                    Console.WriteLine("Denominator should be greater than numinator ");
                }
                break;
            default:
                Console.WriteLine("Select Correct Operator");
                break;
        }


    }
}
