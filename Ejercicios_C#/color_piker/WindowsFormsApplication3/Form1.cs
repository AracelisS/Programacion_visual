using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxred.Text = trackBarred.Value.ToString();
            BackColor = Color.FromArgb(0, 8, 3);

            //obtener los valores
            int red, green, blue;

            //agregarle valor
            red = (int)trackBarred.Value;
            green = (int)trackBargreen.Value;
            blue = (int)trackBarblue.Value;




            //cambiar el color de fondo
            BackColor = Color.FromArgb(red, green, blue);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1Aplicar1_Click(object sender, EventArgs e)
        {
            //cambiar el color de fondo
            BackColor = Color.FromArgb(0, 8, 3);

            //obtener los valores 
            int red, green, blue;
            red = (int) numericUpDownred.Value;
            green = (int)numericUpDowngreen.Value;
            blue = (int)numericUpDownblue.Value;

            BackColor = Color.FromArgb(red, green, blue);

 
        }

        private void textBoxred_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void buttonAplicar2_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(0, 8, 3);

            //obtener los valores
            int red, green, blue;

            //agregarle valor
            red = (int)trackBarred.Value;
            green = (int)trackBargreen.Value;
            blue = (int)trackBarblue.Value;




            //cambiar el color de fondo
            BackColor = Color.FromArgb(red, green, blue);


            
        }

        private void textBoxgreen_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxblue_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBargreen_Scroll(object sender, EventArgs e)
        {

            textBoxgreen.Text = trackBargreen.Value.ToString();
            BackColor = Color.FromArgb(0, 8, 3);

            //obtener los valores
            int red, green, blue;

            //agregarle valor
            red = (int)trackBarred.Value;
            green = (int)trackBargreen.Value;
            blue = (int)trackBarblue.Value;




            //cambiar el color de fondo
            BackColor = Color.FromArgb(red, green, blue);

        }

        private void trackBarblue_Scroll(object sender, EventArgs e)
        {
            textBoxblue.Text = trackBarblue.Value.ToString();
            BackColor = Color.FromArgb(0, 8, 3);

            //obtener los valores
            int red, green, blue;

            //agregarle valor
            red = (int)trackBarred.Value;
            green = (int)trackBargreen.Value;
            blue = (int)trackBarblue.Value;




            //cambiar el color de fondo
            BackColor = Color.FromArgb(red, green, blue);

        }
    }
}
