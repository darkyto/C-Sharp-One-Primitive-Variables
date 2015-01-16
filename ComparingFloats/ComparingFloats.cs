using System;

/*
 * Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
 * Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the 
 * floating-point arithmetic. Therefore, we assume two numbers are equal if they
 * are more closely to each other than a fixed constant eps.
 */

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Floating point precision tester epsilon= 0,000001");
        Console.WriteLine("Enter first floating point number :");  //user can add a floating point double 
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second floating point number :");
        double b = double.Parse(Console.ReadLine());

        double eps = 0.000001d;  //declaration of the precision constant for easier use

        double result = Math.Abs(a - b);   // variable for the result from difference between a-b
        // Console.WriteLine(result); // uncomment if you want to call the result from the operation above 
        
        if (result >= eps)
        {
            bool isEqual = result < eps;  // bool variable for final check - is result (Math.Abs(a-b) within eps range (our precision constant) )
            Console.WriteLine(isEqual);
        }
        else if (result <= eps)
        {
            bool isEqual = result < eps;
            Console.WriteLine(isEqual);
        }
        
        /* Test examples
         * 
        //Number a	Number b	Equal   (with precision eps=0.000001)	Explanation
        5.3	        6.01	    false	The difference of 0.71 is too big (> eps)
        5.00000001	5.00000003	true	The difference 0.00000002 < eps
        5.00000005	5.00000001	true	The difference 0.00000004 < eps
        -0.0000007	0.00000007	true	The difference 0.00000077 < eps
        -4.999999	-4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
        4.999999	4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
        //
        //
         */
        
    }
}

