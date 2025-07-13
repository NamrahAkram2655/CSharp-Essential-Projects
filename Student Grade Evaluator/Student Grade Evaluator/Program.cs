using System;

class studentGradeEvaluator
{
    static void Main()
    {
        Console.WriteLine("Enter Student name : ");
        String name =  Console.ReadLine();

        
        Console.WriteLine("Enter Your Marks 0-100 ");
        double marks = Convert.ToDouble(Console.ReadLine());

        while (marks < 0 || marks > 100)
        {
            Console.WriteLine("Enter Your Correct Marks 0-100 ");
            marks = Convert.ToDouble(Console.ReadLine());
        }
        if (marks >= 90 && marks <= 100)
        {
            Console.WriteLine("Congratulations Your Grade is A ");
        }
        else if (marks >= 80 && marks < 90)
        {
            Console.WriteLine("Good Your Grade is B ");
        }
        else if (marks >= 70 && marks < 80)
        {
            Console.WriteLine("Nice Your Grade is C ");
        }
        else if (marks >= 70 && marks < 60)
        {
            Console.WriteLine("OOps Your Grade is C ");
        }
        else
        {
            Console.WriteLine("Better luck next time You got F grade");
        }

    }
}
