using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm1
{
    class PasteSpace
    {
        public static string PastSp(string Str)
        {
            int q = 0;
            int i = Str.Length * 2;
            char[] ch = new char[i];
            for (i = 0; i < Str.Length; i++)
            {
                ch[q] = Str[i];
                q++;
                ch[q] = ' ';
                q++;
            }
            string st = new string(ch);
            return st;
        }
    }
}
