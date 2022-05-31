using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Pick a number:");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number:");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two numbers:");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            Console.ReadLine();
        }
        //When and if a Catch executes, it generally ends the program at that point.
        catch (FormatException ex) //Catch for if user enters something other than a whole number.
        {
            Console.WriteLine("Please enter a whole number.");
        }
        catch (DivideByZeroException ex) //Catch for if user tries to divide by zero.
        {
            Console.WriteLine("Please dont divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally //Finally happens regardless of wether a Catch executes or not, it will always run AS well as have a database log.
        {
            Console.ReadLine();
        }
    }
}
