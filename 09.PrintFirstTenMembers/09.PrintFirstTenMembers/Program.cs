using System;

class PrintFirstTenMembers
{
    static void Main()
    {
        int totalMembers = 10;
        int firstMember = 2;
        for (int i = firstMember; i < firstMember + totalMembers; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}