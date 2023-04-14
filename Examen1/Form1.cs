using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using System.Drawing.Printing;
using System.Windows.Forms.VisualStyles;

namespace Examen1
{
    public partial class Form1 : Form
    {
        private Operaciones Usuario;
        private Conexion objConexion;
        public Form1()
        {

            InitializeComponent();
            this.objConexion = new Conexion();
            this.Usuario = new Operaciones();
        }

        //metodo cerrar app
        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        //metodo limpiar
        private void LimpiarPantalla()
        {
            //se ponen valores de 0 en los campos
            this.txtNombre1.Clear();
            this.txtCedula2.Clear();
            this.txtHorasNormales.Clear();
            this.txtHorasExtra.Clear();
            this.textboxSalarioBruto.Clear();
            this.textBoxDeducciones.Clear();
            this.textBoxSalarioneto.Clear();

        }

        //al iniciar limpia los datos 
        private void Form1_Load(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }


        //boton calcular salario
        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            //crear registro
            try
            {
                if (MessageBox.Show("Desea registrar al usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //se rellena el objeto con la info del front end
                    Calcular();

                    //almacenar en base de datos
                    RegistrarUsuario();

                    //mensaje de confirmacion
                    MessageBox.Show("Usuario registrado correctamente", "Registro Aplicado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void RegistrarUsuario()
        {
            try
            {
                //se guarda la informacion
                this.objConexion.GUardarUsuario(this.Usuario);

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }



        //calcula el salario
        private void Calcular()
        {
            if (this.txtNombre1.Text == "" || this.txtCedula2.Text == "" || this.txtHorasNormales.Text == "" || this.txtHorasExtra.Text == "")
            {
                MessageBox.Show("Error, Todos los campos tienen que estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Usuario.Nombre = this.txtNombre1.Text;
                this.Usuario.Cedula = int.Parse(this.txtCedula2.Text);
                this.Usuario.horasnormales = double.Parse(this.txtHorasNormales.Text);
                this.Usuario.horasExtra = double.Parse(this.txtHorasExtra.Text);

                //llamo a los metodos que realizan los calculos

                this.textboxSalarioBruto.Text = this.Usuario.CalcularSalario().ToString();
                this.textBoxDeducciones.Text = this.Usuario.calcularDeducciones().ToString();
                this.textBoxSalarioneto.Text = this.Usuario.CalcularSalarioNeto().ToString();
                double aux = this.Usuario.CalcularSalarioNeto();
                aux = this.Usuario.Calcularplanilla(aux);
                this.textBoxplanilla.Text = "" + aux;
            }


        }

        //boton limpiar
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }
        //boton imprimir
        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCedula2.Text == "")
                {
                    MessageBox.Show("Error, primero debe añadir una cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    this.Usuario = objConexion.BuscarBoletaPago(this.txtCedula2.Text);

                    if (this.Usuario ==null)
                    {
                        MessageBox.Show("Error, usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        this.printDocument1 = new PrintDocument();

                        PrinterSettings settings = new PrinterSettings();

                        this.printDocument1.PrinterSettings = settings;

                        this.printDocument1.PrintPage += this.ImprimirTiquete;

                        this.printDocument1.Print();
                    }

                   

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        //funcion de imprimir
        private void ImprimirTiquete(object sender, PrintPageEventArgs e)
        {

            Font fuente = new Font("Arial", 16);


            int Ancho = 500;
            int y = 20;

            e.Graphics.DrawString("----Tiquete cálculo horas laborales----", fuente,
                Brushes.Black, new RectangleF(20, y += 20, Ancho, 30));

            e.Graphics.DrawString("Nombre Completo: " + this.Usuario.Nombre, fuente,
               Brushes.Black, new RectangleF(0, y += 30, Ancho, 30));

            e.Graphics.DrawString("Cedula: " + this.Usuario.Cedula, fuente,
               Brushes.Black, new RectangleF(0, y += 30, Ancho, 30));

            e.Graphics.DrawString("Horas Normales Laboradas: " + this.Usuario.horasnormales, fuente,
                Brushes.Black, new RectangleF(0, y += 30, Ancho, 30));

            e.Graphics.DrawString("Horas Extra Laboradas: " + this.Usuario.horasExtra, fuente,
                Brushes.Black, new RectangleF(0, y += 30, Ancho, 30));

            e.Graphics.DrawString("Salario Bruto: " + this.Usuario.SalarioBruto, fuente,
                Brushes.Black, new RectangleF(0, y += 30, Ancho, 30));

            e.Graphics.DrawString("Deducciones: " + this.Usuario.Deducciones, fuente,
                Brushes.Black, new RectangleF(0, y += 30, Ancho, 30));

            e.Graphics.DrawString("Salario Neto: " + this.Usuario.SalarioNeto, fuente,
                Brushes.Black, new RectangleF(0, y += 30, Ancho, 30));

            e.Graphics.DrawString("Gracias por usar el calculador de salarios ", fuente,
                Brushes.Black, new RectangleF(0, y += 30, Ancho, 30));

        }


    }
}
