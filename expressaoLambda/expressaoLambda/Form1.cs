using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expressaoLambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //para expresao lambda nos objetos
            //verificar quais eventos eles usam 
            // e usar desta forma abaixo
            //(o, e) =>
            this.button1.Click += (o, e) =>
            {
                texto();
            };
        }
        string texto() {
           return textBox1.Text = "Heloworld!.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            texto();
        }
    }
}
