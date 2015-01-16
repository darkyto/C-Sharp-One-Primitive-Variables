using System;

/*
 * Create a program that assigns null values to an integer and to a double variable.
 * Try to print these variables at the console.
 * Try to add some number or the null literal to these variables and print the result
 */

class NullValuesArithmetic
{
    static void Main()
    {
        
        int? nullInteger = null;
        double? nullDouble = null;
        Console.WriteLine("null int= {0}", nullInteger);
        Console.WriteLine("null double=  {0}", nullDouble);

        nullInteger = 4500;
        nullDouble = 23.45678;
        Console.WriteLine("New value of int= {0}", nullInteger);
        Console.WriteLine("New value of double=  {0}", nullDouble);
        
    }
}

