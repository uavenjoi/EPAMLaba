using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPravopisanie
{
    class Cursor
    {
        string text;
        int index;
        int savePos;
        int savePosInt;

        public Cursor(string text)
        {
            this.text = text + ' ';
            index = -1;
        }
        public char NextCh()
        {
            index++;
            return text[index];
        }
        public Boolean IsEnd()
        {
            return index >= text.Length - 1;
        }
        public void SavePos()
        {
            savePos = index;
        }
        public string GetSubStr()
        {
            return text.Substring(savePos, index - savePos);
        }
        public int SavePosInt()
        {
            savePosInt = savePos;
            return savePosInt;
        }

    }
}
