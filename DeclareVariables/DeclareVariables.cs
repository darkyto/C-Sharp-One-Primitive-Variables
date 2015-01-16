using System;

/*
 * Declare five variables choosing for each of them the most appropriate of the types 
 * byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
 * Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
 */
class DeclareVariables
{
    static void Main()
    {
        int firstNum = 52130;
        sbyte secondNum = -115;
        uint thirdNumbeer = 4825932;
        byte forthNumber = 97;
        short fifthNumber = -10000;

        Console.WriteLine("int:{0} , sbyte:{1} , uint:{2} , byte:{3} , short:{4} ", firstNum , secondNum , thirdNumbeer , forthNumber , fifthNumber);
    }
}

