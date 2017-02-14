using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WinFormPravopisanie
{
    public partial class Form1 : Form
    {
        HashSet<string> hs = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_LoadLibrary_Click(object sender, EventArgs e)
        {
            var result = ofd_LoadFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_Path.Text = ofd_LoadFile.FileName;
                var stream = ofd_LoadFile.OpenFile();
                hs.Clear();
                ProgressDialog pd = new ProgressDialog();
                pd.Show(this);
                pd.SetProcent(0);
                using (StreamReader sr = new StreamReader(stream, Encoding.Default))
                {
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);
                    while (!sr.EndOfStream)
                    {
                        hs.Add(sr.ReadLine().Trim());
                        pd.SetProcent((int)(stream.Position / (stream.Length / 100)));
                    }
                }
                pd.Close();
            }
        }

        private void Button_Check_Click(object sender, EventArgs e)
        {
          //Cursor - это лишний класс, написано в стиле 80-х как на паскале. Можно обойтись обычным foreach, String.Split()
            Cursor cursor = new Cursor(rtb_Text.Text);
            Boolean b = true;
            string sravn;

            while (!cursor.IsEnd())
            {
                char ch = cursor.NextCh();
                if (char.IsLetterOrDigit(ch))
                {
                    cursor.SavePos();
                    while(!cursor.IsEnd() && char.IsLetterOrDigit(ch))
                    {
                        ch = cursor.NextCh();
                    }
                    sravn = cursor.GetSubStr();
                    sravn = sravn.ToLower();
                    if (hs.Contains(sravn) != b)
                    {
                        //слишком большой уровень вложенности. Лучше выносить в отдельные методы 
                        for (int i = 0; i < sravn.Length; i++)
                        {
                            int index = cursor.SavePosInt();

                            rtb_Text.Select(index, sravn.Length);
                            rtb_Text.SelectionFont = new Font(rtb_Text.SelectionFont, FontStyle.Underline);
                            rtb_Text.SelectionColor = Color.Red;
                        }
                    }
                }
            }
        }
    }
}
