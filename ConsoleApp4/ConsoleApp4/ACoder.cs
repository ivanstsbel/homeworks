using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ACoder : ICoder
    {
        public string Decode(string str)
        {
            int len = str.Length;
            char[] code = new char[len];
            string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string ALF = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

            for (int i = 0; i < len; i++)
            {
                for (int x = 32; x >= 0; x--)
                {
                    if (str[i] == alf[x])
                    {
                        if (x == 0) x = 33;
                        code[i] = alf[x-1];
                        break;
                    }
                    if (str[i] == ALF[x])
                    {
                        if (x == 0) x = 33;
                        code[i] = ALF[x-1];
                        break;
                    }
                    else code[i] = str[i];
                }
            }
            string text = new string(code);
            return text;
        }

        public string Encode(string str)
        {
            int len = str.Length;
            char[] code = new char[len];
            int y = 0, t = 0;
            string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string ALF = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

            for (int i = 0; i < len; i++)
            {
                for (int x = 0; x < 33; x++)
                {
                    if (str[i] == alf[x])
                    {
                        if (x == 32) x =-1;
                        code[i] = alf[x+1];
                        break;
                    }
                    if (str[i] == ALF[x])
                    {
                        if (x == 32) x = -1;
                        code[i] = ALF[x+1];
                        break;
                    }
                    else code[i] = str[i];

                }

            }
            string text = new string(code);
            return text;
        }
    }
}
