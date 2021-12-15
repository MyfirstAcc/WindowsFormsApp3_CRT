using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3_CRT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChineseRemainderTheorem crt = new ChineseRemainderTheorem();


            foreach (TextBox box in Controls.OfType<TextBox>())
            {
                if (box.Text == "")
                {
                    MessageBox.Show("Заполните поле!");
                    box.Focus();
                    return;
                }

            }
            int[] num = { int.Parse(textBoxN1.Text), int.Parse(textBoxN2.Text), int.Parse(textBoxN3.Text) };
            int[] anu = { int.Parse(textBoxA1.Text), int.Parse(textBoxA2.Text), int.Parse(textBoxA3.Text) };

            int result = crt.Solve(num, anu);
          
            labelX1.Text = result + " = ";
            labelX2.Text = result + " = ";
            labelX3.Text = result + " = ";




        }
    }
}
