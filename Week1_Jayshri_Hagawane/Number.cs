
//2. Write a program to prompt the user for two numbers and then
//print the square of sum of numbers.

internal class program
{
    private static void Main(String[] args)
    {
        
        Console.WriteLine("Enter a number:");
        string num1=Console.ReadLine();
        int userValue1=Convert.ToInt32(num1);
        Console.WriteLine("Enter second number:");
        string num2=Console.ReadLine();
        int userValue2=Convert.ToInt32(num2);
        int c = userValue1 *userValue1+userValue2 *userValue2;
        //int add=Convert.ToInt32(c);
        Console.WriteLine(c);
        //String num3=Console.ReadLine();

    }
}
