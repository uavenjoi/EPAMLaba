using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPravopisanie
{
    public partial class ProgressDialog : Form
    {
        public ProgressDialog()
        {
            InitializeComponent();
            pb.Value = 0;
        }

        public void SetProcent(int procent)
        {
            bool f = pb.Value != procent;
            pb.Value = procent;
            if (f) pb.Refresh();
        }
    }
}
