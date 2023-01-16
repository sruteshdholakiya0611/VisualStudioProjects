using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontDialogApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();

            //fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;

            fontDlg.MaxSize = 40;
            fontDlg.MinSize = 14;

            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Font = fontDlg.Font;
            }
        }
    }
}
