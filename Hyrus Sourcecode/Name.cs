using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hyrus
{
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void weiter_Click(object sender, EventArgs e)
        {
            string namen = namee.Text;


            Hinweis newForm1 = new Hinweis(namen);
            newForm1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
