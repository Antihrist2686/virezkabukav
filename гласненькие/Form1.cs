using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace гласненькие
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string slovo = textBox1.Text;
            char[] bukovu = {'а' , 'о' , 'у' , 'э' , 'и' , 'е' , 'ё' , 'ю', 'я' };
            string result = null;
            foreach (char s in slovo)
            {
                foreach (char eq in bukovu)
                {
                    if (eq == s) result += Convert.ToString(s) + "";
                }
            }
            textBox2.Text = result;
        }
    }
}
