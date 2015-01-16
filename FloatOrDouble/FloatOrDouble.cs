using System;

/* Which of the following values can be assigned to a variable of type float and which to 
 * a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
 * Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 * */

class FloatOrDouble
{
    static void Main()
    {
        double firstNum = 34.567839023d;
        float secondNum = 12.345f;
        double thirdNum = 8923.1234857d;
        float forthNum = 3456.091f;

        Console.WriteLine("\n double: {0} \n float: {1} \n double: {2} \n float: {3}", firstNum, secondNum, thirdNum, forthNum);
    }
}

