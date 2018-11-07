using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8_new_order_
{
    public partial class Form1 : Form
    {
        readonly string resEmpty = "Результат =";
        readonly string resStr = "Результат = {0} 105*k, k = 1, 2, 3, ...";

        public Form1()
        {
            InitializeComponent();
        }

        private void tbRem3_DoubleClick(object sender, EventArgs e)
        {
            if (sender is TextBox) {
                ((TextBox)sender).Clear();
                lbResult.Text = resEmpty;
            }
        }

        private void tbRem3_TextChanged(object sender, EventArgs e)
        {
            lbResult.Text = resEmpty;
        }

        static public int ReminderFind(int k, int m, int n)
        {
            int i;
            for (i = 0; i <= 105; i+=7) {
                if ((i + n - m) % 5 == 0 && (i + n - k) % 3 == 0) break;
            }
            return i + n;
        }

        private void pbAct_Click(object sender, EventArgs e)
        {
            int k, m, n;
            if (!int.TryParse(tbRem3.Text, out k)) {
                lbResult.Text = "Ошибка ввода...";
                tbRem3.Focus();
                return;
            }
            if (!int.TryParse(tbRem5.Text, out m)) {
                lbResult.Text = "Ошибка ввода...";
                tbRem5.Focus();
                return;
            }
            if (!int.TryParse(tbRem7.Text, out n)) {
                lbResult.Text = "Ошибка ввода...";
                tbRem7.Focus();
                return;
            }
            lbResult.Text = String.Format(resStr, ReminderFind(k, m, n).ToString() + " +");
        }

        private void tbRem3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = "";
            if (sender.Equals(tbRem3)) {
                str = "012";
            }
            if (sender.Equals(tbRem5)) {
                str = "01234";
            }
            if (sender.Equals(tbRem7)) {
                str = "0123456";
            }
            if (!str.Contains(e.KeyChar.ToString())) {
                e.KeyChar = '\0';
                return;
            }
            if (sender is TextBox) {
                ((TextBox)sender).Text = "";
            }
        }
    }
}
