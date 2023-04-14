namespace Examen1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxplanilla = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSalarioneto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDeducciones = new System.Windows.Forms.TextBox();
            this.textboxSalarioBruto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHorasExtra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHorasNormales = new System.Windows.Forms.TextBox();
            this.txtCedula2 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pcbCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 117);
            this.panel1.TabIndex = 1;
            // 
            // pcbCerrar
            // 
            this.pcbCerrar.Image = global::Examen1.Properties.Resources.j0432533;
            this.pcbCerrar.Location = new System.Drawing.Point(652, 17);
            this.pcbCerrar.Name = "pcbCerrar";
            this.pcbCerrar.Size = new System.Drawing.Size(85, 75);
            this.pcbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCerrar.TabIndex = 5;
            this.pcbCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbCerrar, "Boton para salir");
            this.pcbCerrar.Click += new System.EventHandler(this.pcbCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seguros del Pacifico";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 317);
            this.panel2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonImprimir);
            this.groupBox3.Controls.Add(this.buttonLimpiar);
            this.groupBox3.Controls.Add(this.btnRegistrar);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(512, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 175);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonImprimir.ForeColor = System.Drawing.Color.White;
            this.buttonImprimir.Location = new System.Drawing.Point(67, 113);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(109, 37);
            this.buttonImprimir.TabIndex = 2;
            this.buttonImprimir.Text = "Imprimir";
            this.toolTip1.SetToolTip(this.buttonImprimir, "Imprime un tiquete con los datos");
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonLimpiar.Location = new System.Drawing.Point(67, 70);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(109, 37);
            this.buttonLimpiar.TabIndex = 1;
            this.buttonLimpiar.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.buttonLimpiar, "Sirve para limpiar los valores de las casillas");
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRegistrar.Location = new System.Drawing.Point(67, 25);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(109, 37);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.toolTip1.SetToolTip(this.btnRegistrar, "Boton para calcular el salario");
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxplanilla);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxSalarioneto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxDeducciones);
            this.groupBox2.Controls.Add(this.textboxSalarioBruto);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(14, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 129);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // textBoxplanilla
            // 
            this.textBoxplanilla.Location = new System.Drawing.Point(594, 80);
            this.textBoxplanilla.Name = "textBoxplanilla";
            this.textBoxplanilla.ReadOnly = true;
            this.textBoxplanilla.Size = new System.Drawing.Size(148, 34);
            this.textBoxplanilla.TabIndex = 12;
            this.textBoxplanilla.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 26);
            this.label9.TabIndex = 11;
            this.label9.Text = "Monto Planilla:";
            // 
            // textBoxSalarioneto
            // 
            this.textBoxSalarioneto.Location = new System.Drawing.Point(177, 83);
            this.textBoxSalarioneto.Name = "textBoxSalarioneto";
            this.textBoxSalarioneto.ReadOnly = true;
            this.textBoxSalarioneto.Size = new System.Drawing.Size(148, 34);
            this.textBoxSalarioneto.TabIndex = 10;
            this.textBoxSalarioneto.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "Salario Neto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Deducciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Salario Bruto:";
            // 
            // textBoxDeducciones
            // 
            this.textBoxDeducciones.Location = new System.Drawing.Point(594, 39);
            this.textBoxDeducciones.Name = "textBoxDeducciones";
            this.textBoxDeducciones.ReadOnly = true;
            this.textBoxDeducciones.Size = new System.Drawing.Size(148, 34);
            this.textBoxDeducciones.TabIndex = 7;
            this.textBoxDeducciones.Text = "0";
            // 
            // textboxSalarioBruto
            // 
            this.textboxSalarioBruto.Location = new System.Drawing.Point(177, 34);
            this.textboxSalarioBruto.Name = "textboxSalarioBruto";
            this.textboxSalarioBruto.ReadOnly = true;
            this.textboxSalarioBruto.Size = new System.Drawing.Size(148, 34);
            this.textboxSalarioBruto.TabIndex = 7;
            this.textboxSalarioBruto.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHorasExtra);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtHorasNormales);
            this.groupBox1.Controls.Add(this.txtCedula2);
            this.groupBox1.Controls.Add(this.txtNombre1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Principales";
            // 
            // txtHorasExtra
            // 
            this.txtHorasExtra.Location = new System.Drawing.Point(166, 141);
            this.txtHorasExtra.Name = "txtHorasExtra";
            this.txtHorasExtra.Size = new System.Drawing.Size(148, 34);
            this.txtHorasExtra.TabIndex = 6;
            this.txtHorasExtra.Text = "0";
            this.toolTip1.SetToolTip(this.txtHorasExtra, "Ingrese sus horas extra laboradas");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Horas Extra:";
            // 
            // txtHorasNormales
            // 
            this.txtHorasNormales.Location = new System.Drawing.Point(205, 102);
            this.txtHorasNormales.Name = "txtHorasNormales";
            this.txtHorasNormales.Size = new System.Drawing.Size(164, 34);
            this.txtHorasNormales.TabIndex = 4;
            this.txtHorasNormales.Text = "0";
            this.toolTip1.SetToolTip(this.txtHorasNormales, "Ingrese sus horas normales laboradas");
            // 
            // txtCedula2
            // 
            this.txtCedula2.Location = new System.Drawing.Point(128, 67);
            this.txtCedula2.Name = "txtCedula2";
            this.txtCedula2.Size = new System.Drawing.Size(254, 34);
            this.txtCedula2.TabIndex = 3;
            this.txtCedula2.Text = "0";
            this.toolTip1.SetToolTip(this.txtCedula2, "INgrese su cedula");
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(140, 27);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(270, 34);
            this.txtNombre1.TabIndex = 0;
            this.txtNombre1.Text = "0";
            this.toolTip1.SetToolTip(this.txtNombre1, "Ingrese su nombre completo");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Horas Normales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cedula:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHorasNormales;
        private System.Windows.Forms.TextBox txtCedula2;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorasExtra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSalarioneto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDeducciones;
        private System.Windows.Forms.TextBox textboxSalarioBruto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxplanilla;
        private System.Windows.Forms.Label label9;
    }
}

