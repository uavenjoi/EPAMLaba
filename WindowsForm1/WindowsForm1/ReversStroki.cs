using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm1
{
    public class RevStr
    {
        public static string StrRev(string Str)
        {
            int q = 0;
            int i = Str.Length;
            char[] ch = new char[i];

            for (q = 0; q < Str.Length; q++)
            {
                ch[q] = Str[i - 1];
                i--;
            }
            string st = new string(ch);
            return st;
        }
    }
}
