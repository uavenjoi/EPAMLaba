using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Translation trnsl = new Translation();
            str = trnsl.Translate(str);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
class Translation
{
    Dictionary<char, string> MatrixDict;
    public Translation()
    {
        MatrixDict = new Dictionary<char,string>();
        MatrixDict.Add('а',"a");
        MatrixDict.Add('б',"b");
        MatrixDict.Add('в',"v");
        MatrixDict.Add('г',"g");
        MatrixDict.Add('д',"d");
        MatrixDict.Add('е',"e");
        MatrixDict.Add('ё',"yo");
        MatrixDict.Add('ж',"zh");
        MatrixDict.Add('з',"z");
        MatrixDict.Add('и',"i");
        MatrixDict.Add('й',"y");
        MatrixDict.Add('к',"k");
        MatrixDict.Add('л',"l");
        MatrixDict.Add('м',"m");
        MatrixDict.Add('н',"n");
        MatrixDict.Add('о',"o");
        MatrixDict.Add('п',"p");
        MatrixDict.Add('р',"r");
        MatrixDict.Add('с',"s");
        MatrixDict.Add('т',"t");
        MatrixDict.Add('у',"u");
        MatrixDict.Add('ф',"f");
        MatrixDict.Add('х',"h");
        MatrixDict.Add('ц',"c");
        MatrixDict.Add('ч',"ch");
        MatrixDict.Add('ш',"sh");
        MatrixDict.Add('щ',"sch");
        MatrixDict.Add('ъ',"'");
        MatrixDict.Add('ы',"y");
        MatrixDict.Add('ь',"'");
        MatrixDict.Add('э',"e");
        MatrixDict.Add('ю',"yu");
        MatrixDict.Add('я',"ya");
        MatrixDict.Add(' '," ");
    }
    public string Translate(string text)
    {
        string res = string.Empty;
        char ch;
        Boolean b = true;

        for(int i = 0; i < text.Length; i++)
        {
            ch = text[i];
            char ch1 = Cha(ch);


            if (b == MatrixDict.ContainsKey(ch1))
            {
                string str = ch.ToString();
                if (str == str.ToLower())
                {
                    res += MatrixDict[ch];
                } else if (str == str.ToUpper())
                {
                    str = str.ToLower();
                    ch = str[0];
                    str = MatrixDict[ch];
                    str = str.ToUpper();
                    res += str;
                }
            }
            else res += ch;
        }
        return res;
    }
    public char Cha(char vhodCh)
    {
        return vhodCh.ToString().ToLower()[0];
    }
}
