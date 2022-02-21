using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dia_de_la_semana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor;
            valor = textBox1.Text;
            
            if(valor== "1")
            {
                MessageBox.Show("Lunes");
            }
            if (valor=="2")
            {
                MessageBox.Show("Martes");
            }
            if (valor=="3")
            {
                MessageBox.Show("Miercoles");
            }
            if (valor=="4")
            {
                MessageBox.Show("Jueves");
            }
            if(valor=="5")
            {
                MessageBox.Show("Viernes");

            }
            if(valor=="Sabado")
            {
                MessageBox.Show("Sabado");
            }
            if(valor=="Domingo")
            {
                MessageBox.Show("Domingo");
            }









        }
    }
}
