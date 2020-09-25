using System;
using System.Text;

namespace upperANDlower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            uperLower("hELLO wORLD!");
        }

        public static void uperLower(string str)
        {
            System.Text.StringBuilder st = new System.Text.StringBuilder(str);

            for(int i = 0; i < st.Length; i++)
            {
                if (System.Char.IsLower(st[i]) == true)
                    st[i] = System.Char.ToUpper(st[i]);
                else if (System.Char.IsUpper(st[i]) == true)
                    st[i] = System.Char.ToLower(st[i]);
            }
            Console.Write(st);
        }

    }
}
