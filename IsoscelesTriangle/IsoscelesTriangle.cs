using System;
using System.Text;

/*
 * Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
  
         ©

        © ©

       ©   ©

      © © © ©
   
 * Note: The © symbol may be displayed incorrectly at the console so you may need 
 * to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.
 * 
 * Note: Under old versions of Windows the © symbol may still 
 * be displayed incorrectly, regardless of how much effort you put to fix it.
 * 
 * 
 */

class IsoscelesTriangle
{

    static void Main()
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char copyrightSign = '\u00a9'; // copyright sign © - check local font settings if console not showing properly ©

        char emptySpace = ' '; //variable for drawing an empty space
        

        for (int row = 0; row < 9; row++)  // loop for drawing the number of lines needed
        {
            Console.WriteLine();    // actual command for new line for every part of the previous loop

            for (int col = 0; col <= 8; col++)  // inside nested loop for drawing the emapty spaces needed in the x-coordinate on every new line
            {
                
                Console.Write(emptySpace); //the actual command for drawing an empty space  something like thaat without quotes:("           ")
                

                if (row == 1 && col == 5)   // now some if-else conditions to show where on x-y coordinate we will draw © 
                {
                    Console.Write(copyrightSign);  //when coordinates are reached then this command is drawing no the right place
                }
                else if (row == 3 && col == 4)
                {
                    Console.Write(copyrightSign);
                }
                else if (row == 3 && col == 5)
                {
                    Console.Write(copyrightSign);
                }
                else if (row == 5 && col == 3)
                {
                    Console.Write(copyrightSign);
                }
                else if (row == 5 && col == 6)
                {
                    Console.Write(copyrightSign);
                }
                else if (row == 7 && col == 2)
                {
                    Console.Write(copyrightSign);
                }
                else if (row == 7 && col == 3)
                {
                    Console.Write(copyrightSign);
                }
                else if (row == 7 && col == 4)
                {
                    Console.Write(copyrightSign);
                }
                else if (row == 7 && col == 5)
                {
                    Console.Write(copyrightSign);
                }
                
            }
        }

        Console.WriteLine();
        Console.WriteLine();

    }

    //THE SIMPLE WAY 
    //
    //Console.OutputEncoding = System.Text.Encoding.UTF8;
    //char copyRight = '\u00a9';
    //
    //Console.WriteLine("   {0}   ", copyRight);
    //Console.WriteLine();
    //Console.WriteLine("  {0} {0}  ", copyRight);
    //Console.WriteLine();
    //Console.WriteLine(" {0}   {0} ", copyRight);
    //Console.WriteLine();
    //Console.WriteLine("{0} {0} {0} {0}", copyRight);
    //Console.WriteLine();

}

