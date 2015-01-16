using System;

/*'
 * Declare two string variables and assign them with Hello and World.
 * 
 * Declare an object variable and assign it with the concatenation of the first two variables 
 * (mind adding an interval between).
 * 
 * Declare a third string variable and initialize it with the 
 * value of the object variable (you should perform type casting).
 */
class StringsAndObjects
{
    static void Main()
    {

        string firstWord = "Hello"; //first string variable
        string secondWord = "World"; //second string variable
        Console.WriteLine("{0} {1}", firstWord , secondWord); //test

        object sumWords = firstWord + " " + secondWord; // object variable (concatenation of the two string + interval)
        Console.WriteLine(sumWords); //test

        string objectWord = (string)sumWords; // new string variable and type casting for the object
        Console.WriteLine(objectWord); //last tesst

    }
}

