using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            // declarar variables 
            string valor1, valor2;

            //asignarle un valor a la variable
            valor1 = textBox1.Text;
            valor2 = textBox2.Text;

            //validar que no este vacio 
            if (valor1.Trim() == "")
            {
                MessageBox.Show(" el numero 1 no puede etar vacio");
                return;
            }

            //hacer el calculo
            int resultado = int.Parse(valor1) + int.Parse(valor2);

            //mostrar el calculo
            textBox3.Text = resultado.ToString();
               
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string valor1, valor2;

            valor1 = textBox1.Text;
            valor2 = textBox2.Text;

            if (valor1.Trim() == "")
            {
                MessageBox.Show(" el numero 1 no puedes estar vacio");
                return;
            }

                int resultado = int.Parse(valor1) - int.Parse(valor2);

                textBox3.Text = resultado.ToString();
            

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string valor1, valor2;

            valor1 = textBox1.Text;
            valor2 = textBox2.Text;

            if (valor1.Trim() == "")
            {
                MessageBox.Show(" el numero 1 no puede estar vacio.");
                return;
            }

            int resultado = int.Parse(valor1) * int.Parse(valor2);

            textBox3.Text = resultado.ToString();



        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string valor1, valor2;

            valor1 = textBox1.Text;
            valor2 = textBox2.Text;

            if (valor1.Trim() == "")
            {
                MessageBox.Show("el numero1 no puede estar vacio");
                return;
                    
            }
            float resultado = float.Parse(valor1) / float.Parse(valor2);

            textBox3.Text = resultado.ToString();
        
        }


    }
}
