using System;

/*
 *A bank account has a holder name (first name, middle name and last name), 
 *available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
 *Declare the variables needed to keep the information for a single bank account 
 *using the appropriate data types and descriptive names.  Zhōnghuá Rénmín Gònghéguó Zhǔxí,
 */

class BankAccountData
{
    static void Main()
    {
        string firstName = "Zhōnghuá";
        string middleName = "Rénmín";
        string lastName = "Gònghéguó Zhǔxí";
        decimal accountBalanceUS = 26500257.52M;
        string bankName = "National Bank of China";
        string numberIBAN = "CH93 0076 2011 6238 5295 7";
        ulong creditCardFirst = 1111222233334444u;
        ulong creditCardSecond = 2111222233335555u;
        ulong creditCardThird = 3111222233336666u;

        Console.WriteLine("My name is {0} {1} {2} and \nI am the President of People's Republic of China!",firstName , middleName , lastName);
        Console.WriteLine("My bank balance in the {0} is : {1} US dollars", bankName, accountBalanceUS);
        Console.WriteLine("IBAN : {0}", numberIBAN);
        Console.WriteLine("First credit card number : {0}", creditCardFirst);
        Console.WriteLine("First credit card number : {0}", creditCardSecond);
        Console.WriteLine("First credit card number : {0}", creditCardThird);

    }
}

