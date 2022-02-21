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
            this.numericUpDownred = new System.Windows.Forms.NumericUpDown();
            this.numericUpDowngreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownblue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxred = new System.Windows.Forms.TextBox();
            this.textBoxgreen = new System.Windows.Forms.TextBox();
            this.textBoxblue = new System.Windows.Forms.TextBox();
            this.trackBarred = new System.Windows.Forms.TrackBar();
            this.trackBargreen = new System.Windows.Forms.TrackBar();
            this.trackBarblue = new System.Windows.Forms.TrackBar();
            this.button1Aplicar1 = new System.Windows.Forms.Button();
            this.buttonAplicar2 = new System.Windows.Forms.Button();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowngreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownblue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBargreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarblue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownred
            // 
            this.numericUpDownred.Location = new System.Drawing.Point(3, 28);
            this.numericUpDownred.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownred.Name = "numericUpDownred";
            this.numericUpDownred.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownred.TabIndex = 0;
            this.numericUpDownred.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownred.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDowngreen
            // 
            this.numericUpDowngreen.Location = new System.Drawing.Point(101, 28);
            this.numericUpDowngreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDowngreen.Name = "numericUpDowngreen";
            this.numericUpDowngreen.Size = new System.Drawing.Size(65, 20);
            this.numericUpDowngreen.TabIndex = 1;
            // 
            // numericUpDownblue
            // 
            this.numericUpDownblue.Location = new System.Drawing.Point(200, 28);
            this.numericUpDownblue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownblue.Name = "numericUpDownblue";
            this.numericUpDownblue.Size = new System.Drawing.Size(72, 20);
            this.numericUpDownblue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "blue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "red";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "green";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "blue";
            // 
            // textBoxred
            // 
            this.textBoxred.Enabled = false;
            this.textBoxred.Location = new System.Drawing.Point(43, 129);
            this.textBoxred.Name = "textBoxred";
            this.textBoxred.Size = new System.Drawing.Size(25, 20);
            this.textBoxred.TabIndex = 11;
            this.textBoxred.Text = "25";
            this.textBoxred.TextChanged += new System.EventHandler(this.textBoxred_TextChanged);
            // 
            // textBoxgreen
            // 
            this.textBoxgreen.Enabled = false;
            this.textBoxgreen.Location = new System.Drawing.Point(43, 167);
            this.textBoxgreen.Name = "textBoxgreen";
            this.textBoxgreen.Size = new System.Drawing.Size(25, 20);
            this.textBoxgreen.TabIndex = 12;
            this.textBoxgreen.Text = "170";
            this.textBoxgreen.TextChanged += new System.EventHandler(this.textBoxgreen_TextChanged);
            // 
            // textBoxblue
            // 
            this.textBoxblue.Enabled = false;
            this.textBoxblue.Location = new System.Drawing.Point(43, 207);
            this.textBoxblue.Name = "textBoxblue";
            this.textBoxblue.Size = new System.Drawing.Size(25, 20);
            this.textBoxblue.TabIndex = 13;
            this.textBoxblue.Text = "0";
            this.textBoxblue.TextChanged += new System.EventHandler(this.textBoxblue_TextChanged);
            // 
            // trackBarred
            // 
            this.trackBarred.Location = new System.Drawing.Point(90, 129);
            this.trackBarred.Maximum = 255;
            this.trackBarred.Name = "trackBarred";
            this.trackBarred.Size = new System.Drawing.Size(169, 45);
            this.trackBarred.TabIndex = 14;
            this.trackBarred.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBargreen
            // 
            this.trackBargreen.Location = new System.Drawing.Point(90, 167);
            this.trackBargreen.Maximum = 255;
            this.trackBargreen.Name = "trackBargreen";
            this.trackBargreen.Size = new System.Drawing.Size(169, 45);
            this.trackBargreen.TabIndex = 15;
            this.trackBargreen.Scroll += new System.EventHandler(this.trackBargreen_Scroll);
            // 
            // trackBarblue
            // 
            this.trackBarblue.Location = new System.Drawing.Point(90, 207);
            this.trackBarblue.Maximum = 255;
            this.trackBarblue.Name = "trackBarblue";
            this.trackBarblue.Size = new System.Drawing.Size(169, 45);
            this.trackBarblue.TabIndex = 16;
            this.trackBarblue.Scroll += new System.EventHandler(this.trackBarblue_Scroll);
            // 
            // button1Aplicar1
            // 
            this.button1Aplicar1.Location = new System.Drawing.Point(-4, 63);
            this.button1Aplicar1.Name = "button1Aplicar1";
            this.button1Aplicar1.Size = new System.Drawing.Size(72, 19);
            this.button1Aplicar1.TabIndex = 17;
            this.button1Aplicar1.Text = "aplicar";
            this.button1Aplicar1.UseVisualStyleBackColor = true;
            this.button1Aplicar1.Click += new System.EventHandler(this.button1Aplicar1_Click);
            // 
            // buttonAplicar2
            // 
            this.buttonAplicar2.Location = new System.Drawing.Point(9, 239);
            this.buttonAplicar2.Name = "buttonAplicar2";
            this.buttonAplicar2.Size = new System.Drawing.Size(75, 23);
            this.buttonAplicar2.TabIndex = 18;
            this.buttonAplicar2.Text = "aplicar";
            this.buttonAplicar2.UseVisualStyleBackColor = true;
            this.buttonAplicar2.Click += new System.EventHandler(this.buttonAplicar2_Click);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(3, 88);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(260, 45);
            this.trackBar4.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 261);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.buttonAplicar2);
            this.Controls.Add(this.button1Aplicar1);
            this.Controls.Add(this.trackBarblue);
            this.Controls.Add(this.trackBargreen);
            this.Controls.Add(this.trackBarred);
            this.Controls.Add(this.textBoxblue);
            this.Controls.Add(this.textBoxgreen);
            this.Controls.Add(this.textBoxred);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownblue);
            this.Controls.Add(this.numericUpDowngreen);
            this.Controls.Add(this.numericUpDownred);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowngreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownblue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBargreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarblue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownred;
        private System.Windows.Forms.NumericUpDown numericUpDowngreen;
        private System.Windows.Forms.NumericUpDown numericUpDownblue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxred;
        private System.Windows.Forms.TextBox textBoxgreen;
        private System.Windows.Forms.TextBox textBoxblue;
        private System.Windows.Forms.TrackBar trackBarred;
        private System.Windows.Forms.TrackBar trackBargreen;
        private System.Windows.Forms.TrackBar trackBarblue;
        private System.Windows.Forms.Button button1Aplicar1;
        private System.Windows.Forms.Button buttonAplicar2;
        private System.Windows.Forms.TrackBar trackBar4;

    }
}

