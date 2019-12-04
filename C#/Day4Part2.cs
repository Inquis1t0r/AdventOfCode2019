using System;
using System.Linq;


namespace AoC2019Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            //TODO: Part 2
            foreach (int password in Enumerable.Range(234208, 765869 - 234208))
            {
                //int pswdNum = password;
                int pswdNum = 121233; //for testing

                bool isAscending = true;
                bool hasDuplicate = false;
                var last = 0;
                int dupcount = 0;

                while (pswdNum != 0)
                {
                    last = pswdNum % 10;
                    pswdNum = pswdNum / 10;

                    if (pswdNum % 10 > last)
                    {
                        isAscending = false;
                        break;
                    }

                    if (pswdNum % 10 == last)
                    {
                        hasDuplicate = true;
                    }
                }

                if (isAscending && hasDuplicate)
                {
                    result += 1;
                }
                    
            }
            Console.WriteLine(result);
        }

    }
}
