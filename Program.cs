using System;


namespace Examen
{
    public class DiagramToCode
    {
        static void Main()
        {
            const string MSG_INPUT_NUMS = "Introdueix 20 números: ";

            Console.WriteLine(MSG_INPUT_NUMS);            


            int[] nums = new int[20];

            

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = ValidatorNum(i, "num");
            }
        }

        static int ValidatorNum(int num, string Correct)
        {
            const string MSG_ERROR = "Error, introdueix un número vàlid.";
            if (num == 0)
            {
                return num;
            }
            else
            {
                Console.WriteLine(MSG_ERROR);
                return -1;
            }
        }
    }
}
