using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hyrus
{
    public partial class Hinweis : Form
    {

        public Hinweis(String namen)
        {
            this.namen = namen;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("start.exe");
            

            this.Close();
        }

        private void Bes_CheckedChanged(object sender, EventArgs e)
        {
            if (Bes.Checked == true)
            {
                Start.Enabled = true;
            }

            if (Bes.Checked == false)
            {
                Start.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void namea_TextChanged(object sender, EventArgs e)
        {
            namea.Text = "Hallo " + namen + "!";
        }

        public String namen;

        private void relaod_Click(object sender, EventArgs e)
        {
            namea.Text = "Hallo " + namen + "!";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Hinweis_Load(object sender, EventArgs e)
        {
            namea.Text = "Hallo " + namen + "!";
        }
    }
}