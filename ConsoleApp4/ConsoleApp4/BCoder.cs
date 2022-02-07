using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class BCoder : ICoder
    {
        public string Decode(string str)
        {
            int y = 0, t = 0;
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
                        y =32 - x;
                        t = y;
                        code[i] = alf[t];
                        break;
                    }
                    if (str[i] == ALF[x])
                    {
                        y = 32 - x;
                        t = y;
                        code[i] = ALF[t];
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
            int y = 0,t = 0;
            int len = str.Length;
            char[] code = new char[len];
            string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string ALF = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"; 

            for (int i = 0; i < len; i++)
            {
                for(int x = 0;x<33;x++)
                {
                    if (str[i] == alf[x])
                    {
                        y = x;
                        t = 32 - y;
                        code[i] = alf[t];
                        break;
                    }
                    if (str[i] == ALF[x])
                    {
                        y = x;
                        t = 32 - y;
                        code[i] = ALF[t];
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
