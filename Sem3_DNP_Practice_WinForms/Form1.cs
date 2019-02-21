using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem3_DNP_Practice_WinForms
{
    public partial class Form1 : Form
    {
        DelegatesLibrary.MyDelegates delegatesLib = new DelegatesLibrary.MyDelegates();

        public Form1()
        {
            InitializeComponent();
            // Note how the assignment of methods to CLick behaves as a delegate
            button1.Click += richTextBox1_TextChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.AliceBlue;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = delegatesLib.ReturnLine();

        }
    }
}
