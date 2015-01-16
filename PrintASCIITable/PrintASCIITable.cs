using System;
using System.Text;

/*
 * 
 *Find online more information about ASCII (American Standard Code for Information Interchange) 
 *and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
 *Note: Some characters have a special purpose and will not be displayed as expected. 
 *You may skip them or display them differently.
 *
 */

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine();

        int min = 0;                        //  the start of ACII table count
        int max = 255;                      //  the end of ACII table count
        for (int i = min; i < max; i++)     //  the loop that goes through the ACII table 0-255
        {
            
            char c = (char)i;            //  get the ACII symbol by its count
            Console.Write(" " +c);       //  actual print of each member of the loop
           
        }  
    }
}

