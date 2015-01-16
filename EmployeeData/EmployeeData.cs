using System;

/*
 * A marketing company wants to keep record of its employees. 
 * Each record would have the following characteristics:
 * 
 * First name
 * Last name
 * Age (0...100)
 * Gender (m or f)
 * Personal ID number (e.g. 8306112507)
 * Unique employee number (27560000…27569999)
 * 
 * Declare the variables needed to keep the information for a single employee 
 * using appropriate primitive data types. Use descriptive names. 
 * Print the data at the console.
 */

class EmployeeData
{
    static void Main()
    {
        string firstName = "Divided";
        string lastName = "Zero";
        byte userAge = 35;
        char userGender = 'm';
        ulong userID = 8306112507;
        int uniqueEmplNum = 27569999;

        Console.WriteLine("Employee First name : {0}\nEmployee Last name : {1}\nEmployee current age : {2}", firstName , lastName, userAge);
        Console.WriteLine("Employee gender : {0}\nEmployee personal ID number : {1}\nUnique employee number : {2}\n", userGender, userID, uniqueEmplNum);
        // declaring the variables in proper data types and then printing the results


        //// some additional interactivity test added below

        //Console.WriteLine("Please enter employee First Name :");
        //firstName = Console.ReadLine();
        //Console.WriteLine("Please enter employee Last Name :");
        //lastName = Console.ReadLine();
        //Console.WriteLine("Please enter employee current age :");
        //userAge = Convert.ToByte(Console.ReadLine());
        //Console.WriteLine("Please enter employee gender (m/f) :");
        //userGender = Convert.ToChar(Console.ReadLine());
        //Console.WriteLine("Please enter employee Personal ID number :");
        //userID = Convert.ToUInt64(Console.ReadLine());
        //Console.WriteLine("Please enter employee Unique employee number :");
        //uniqueEmplNum = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("New data received!");
        //Console.WriteLine("Employee First name : {0}\nEmployee Last name : {1}\nEmployee current age : {2}", firstName, lastName, userAge);
        //Console.WriteLine("Employee gender : {0}\nEmployee personal ID number : {1}\nUnique employee number : {2}\n", userGender, userID, uniqueEmplNum);


    }
}

