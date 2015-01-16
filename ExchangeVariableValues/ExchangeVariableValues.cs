using System;

/*
 * Declare two integer variables a and b and assign them with 5 and 10 and 
 * after that exchange their values by using some programming logic.
 * Print the variable values before and after the exchange.
*/

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("int a="+ a);
        Console.WriteLine("int b=" + b);
        int c = a + b; //creating third value sum of th roginal two.
        a = 10;  //assign new value to a
        b = c - a; // some math will do the trick to exchange the values of a and b
        Console.WriteLine("Now int a=" + a);
        Console.WriteLine("and now int b=" + b);


        ///other example without third variable
        int x = 5;
        int y = 10;
        Console.WriteLine("x is "+ x);
        Console.WriteLine("y is "+ y);

        x = x + y; // (5+10)    x=15
        y = x - y; // (15-10)   y=5
        x = x - y; // (15-5)    x=10
        Console.WriteLine("x is "+ x);
        Console.WriteLine("y is "+ y);
    }
}

