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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOLA");

            //Declarar las variable
            string NOMBRE, apellido, contraseña, correo;
            //Asignar un valor

            NOMBRE = textBox1NOMBRE.Text;
            apellido = textBox2APELLIDO.Text;
            contraseña = textBox4CONTRASEÑA.Text;
            correo = textBox3CORREO.Text;

            if (NOMBRE.Trim() == "")
            {
                //MessageBox.Show("El nombre no puede estar vacio. ");
                //textBox1NOMBRE.Focus();
                //return;
                validanombre.Visible=true;
                validanombre.Text="El nombre no puede estar vacio";
                validanombre.ForeColor= Color.Red;
            
            }
            if (apellido.Trim() == "") 
            {
               // MessageBox.Show("El apellido no puede estar vacio. ");
                //textBox2APELLIDO.Focus();
                //return;
                label10validarapellido.Visible = true;
                label10validarapellido.Text = "El apellido no puede estar vacio.";
                label10validarapellido.ForeColor= Color.Red;

            }
            if (contraseña.Trim() == "") 
            {
               // MessageBox.Show("La contraseña no puede estar vacia. ");
                //textBox4CONTRASEÑA.Focus();
                //return;
                label12validarcontraseña.Visible = true;
                label12validarcontraseña.Text = "El apellido no puede estar vacio. ";
                label12validarcontraseña.ForeColor = Color.Red;


            }
            if (correo.Trim() == "") 
            {
               // MessageBox.Show("El correo no puede estar vacio. ");
                //textBox3CORREO.Focus();
                //return;
                label11validarcorreo.Visible = true;
                label11validarcorreo.Text = "El correo no puede estar vacio. ";
                label11validarcorreo.ForeColor = Color.Red;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3CORREO_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1SEXO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
