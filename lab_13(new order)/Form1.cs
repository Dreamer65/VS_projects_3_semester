using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace lab_13_new_order_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] Crypt(params string[] str)
        {
            for (int i = 0; i < str.Length; i++) {
                str[i] = string.Join("",str[i].ToCharArray().Reverse());
            }
            return str;
        }

        private void pbDecrypting_Click(object sender, EventArgs e)
        {
            string str = tbCrypted.Text.ToLower();
            Functions.ExtraSpaces(ref str);
            tbCrypted.Text = str;
            tbNormal.Text = string.Join(" ", Crypt(str.Split(' ')));
        }

        private void pbCrypting_Click(object sender, EventArgs e)
        {
            string str = tbNormal.Text.ToLower();
            Functions.ExtraSpaces(ref str);
            tbCrypted.Text = string.Join(" ", Crypt(str.Split(' ')));
        }

        private void tbCrypted_DoubleClick(object sender, EventArgs e)
        {
            if (sender is TextBox) {
                ((TextBox)sender).Clear();
            }
        }
    }
}
