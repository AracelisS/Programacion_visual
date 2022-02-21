namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1NOMBRE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1SEXO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2APELLIDO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3MES = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3CORREO = new System.Windows.Forms.TextBox();
            this.textBox4CONTRASEÑA = new System.Windows.Forms.TextBox();
            this.comboBox4AÑO = new System.Windows.Forms.ComboBox();
            this.comboBox2DIA = new System.Windows.Forms.ComboBox();
            this.validanombre = new System.Windows.Forms.Label();
            this.label10validarapellido = new System.Windows.Forms.Label();
            this.label11validarcorreo = new System.Windows.Forms.Label();
            this.label12validarcontraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRATE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1NOMBRE
            // 
            this.textBox1NOMBRE.Location = new System.Drawing.Point(335, 78);
            this.textBox1NOMBRE.Name = "textBox1NOMBRE";
            this.textBox1NOMBRE.Size = new System.Drawing.Size(100, 20);
            this.textBox1NOMBRE.TabIndex = 1;
            this.textBox1NOMBRE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(328, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "REGISTRATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1SEXO
            // 
            this.comboBox1SEXO.FormattingEnabled = true;
            this.comboBox1SEXO.Location = new System.Drawing.Point(316, 181);
            this.comboBox1SEXO.Name = "comboBox1SEXO";
            this.comboBox1SEXO.Size = new System.Drawing.Size(100, 21);
            this.comboBox1SEXO.TabIndex = 7;
            this.comboBox1SEXO.SelectedIndexChanged += new System.EventHandler(this.comboBox1SEXO_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(267, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(273, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Es gratis (y lo seguira siendo)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateGray;
            this.label4.Location = new System.Drawing.Point(267, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2APELLIDO
            // 
            this.textBox2APELLIDO.Location = new System.Drawing.Point(336, 106);
            this.textBox2APELLIDO.Name = "textBox2APELLIDO";
            this.textBox2APELLIDO.Size = new System.Drawing.Size(100, 20);
            this.textBox2APELLIDO.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(267, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Correo Electronico:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SlateGray;
            this.label6.Location = new System.Drawing.Point(267, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contraseña Nueva:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SlateGray;
            this.label7.Location = new System.Drawing.Point(267, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sexo:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SlateGray;
            this.label8.Location = new System.Drawing.Point(267, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fecha de nacimiento:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBox3MES
            // 
            this.comboBox3MES.FormattingEnabled = true;
            this.comboBox3MES.Location = new System.Drawing.Point(436, 209);
            this.comboBox3MES.Name = "comboBox3MES";
            this.comboBox3MES.Size = new System.Drawing.Size(15, 21);
            this.comboBox3MES.TabIndex = 19;
            this.comboBox3MES.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "¿Porque debo dar esta información?";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox3CORREO
            // 
            this.textBox3CORREO.Location = new System.Drawing.Point(401, 131);
            this.textBox3CORREO.Name = "textBox3CORREO";
            this.textBox3CORREO.Size = new System.Drawing.Size(76, 20);
            this.textBox3CORREO.TabIndex = 22;
            this.textBox3CORREO.TextChanged += new System.EventHandler(this.textBox3CORREO_TextChanged);
            // 
            // textBox4CONTRASEÑA
            // 
            this.textBox4CONTRASEÑA.Location = new System.Drawing.Point(401, 155);
            this.textBox4CONTRASEÑA.Name = "textBox4CONTRASEÑA";
            this.textBox4CONTRASEÑA.Size = new System.Drawing.Size(77, 20);
            this.textBox4CONTRASEÑA.TabIndex = 23;
            this.textBox4CONTRASEÑA.UseSystemPasswordChar = true;
            // 
            // comboBox4AÑO
            // 
            this.comboBox4AÑO.FormattingEnabled = true;
            this.comboBox4AÑO.Location = new System.Drawing.Point(457, 210);
            this.comboBox4AÑO.Name = "comboBox4AÑO";
            this.comboBox4AÑO.Size = new System.Drawing.Size(15, 21);
            this.comboBox4AÑO.TabIndex = 24;
            // 
            // comboBox2DIA
            // 
            this.comboBox2DIA.FormattingEnabled = true;
            this.comboBox2DIA.Location = new System.Drawing.Point(413, 208);
            this.comboBox2DIA.Name = "comboBox2DIA";
            this.comboBox2DIA.Size = new System.Drawing.Size(15, 21);
            this.comboBox2DIA.TabIndex = 25;
            // 
            // validanombre
            // 
            this.validanombre.AutoSize = true;
            this.validanombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validanombre.ForeColor = System.Drawing.Color.SlateGray;
            this.validanombre.Location = new System.Drawing.Point(478, 85);
            this.validanombre.Name = "validanombre";
            this.validanombre.Size = new System.Drawing.Size(0, 15);
            this.validanombre.TabIndex = 26;
            this.validanombre.Visible = false;
            this.validanombre.Click += new System.EventHandler(this.label10_Click);
            // 
            // label10validarapellido
            // 
            this.label10validarapellido.AutoSize = true;
            this.label10validarapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10validarapellido.ForeColor = System.Drawing.Color.SlateGray;
            this.label10validarapellido.Location = new System.Drawing.Point(478, 111);
            this.label10validarapellido.Name = "label10validarapellido";
            this.label10validarapellido.Size = new System.Drawing.Size(0, 15);
            this.label10validarapellido.TabIndex = 27;
            this.label10validarapellido.Visible = false;
            this.label10validarapellido.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // label11validarcorreo
            // 
            this.label11validarcorreo.AutoSize = true;
            this.label11validarcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11validarcorreo.ForeColor = System.Drawing.Color.SlateGray;
            this.label11validarcorreo.Location = new System.Drawing.Point(478, 137);
            this.label11validarcorreo.Name = "label11validarcorreo";
            this.label11validarcorreo.Size = new System.Drawing.Size(0, 15);
            this.label11validarcorreo.TabIndex = 28;
            this.label11validarcorreo.Visible = false;
            // 
            // label12validarcontraseña
            // 
            this.label12validarcontraseña.AutoSize = true;
            this.label12validarcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12validarcontraseña.ForeColor = System.Drawing.Color.SlateGray;
            this.label12validarcontraseña.Location = new System.Drawing.Point(477, 162);
            this.label12validarcontraseña.Name = "label12validarcontraseña";
            this.label12validarcontraseña.Size = new System.Drawing.Size(0, 15);
            this.label12validarcontraseña.TabIndex = 29;
            this.label12validarcontraseña.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(746, 311);
            this.Controls.Add(this.label12validarcontraseña);
            this.Controls.Add(this.label11validarcorreo);
            this.Controls.Add(this.label10validarapellido);
            this.Controls.Add(this.validanombre);
            this.Controls.Add(this.comboBox2DIA);
            this.Controls.Add(this.comboBox4AÑO);
            this.Controls.Add(this.textBox4CONTRASEÑA);
            this.Controls.Add(this.textBox3CORREO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox3MES);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2APELLIDO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1SEXO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1NOMBRE);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.SlateGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FACEBOOK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1NOMBRE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1SEXO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2APELLIDO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3MES;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3CORREO;
        private System.Windows.Forms.TextBox textBox4CONTRASEÑA;
        private System.Windows.Forms.ComboBox comboBox4AÑO;
        private System.Windows.Forms.ComboBox comboBox2DIA;
        private System.Windows.Forms.Label validanombre;
        private System.Windows.Forms.Label label10validarapellido;
        private System.Windows.Forms.Label label11validarcorreo;
        private System.Windows.Forms.Label label12validarcontraseña;
    }
}

