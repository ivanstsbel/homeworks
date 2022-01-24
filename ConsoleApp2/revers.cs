using System;

namespace ConsoleApp2
{
    public static class revers
    {

        public static string reverse(string str)
        {
            int len = str.Length;
            char[] sReverse = str.ToCharArray();
            Array.Reverse(sReverse);
            str = new string(sReverse);
            return str;
        }
    }
}
