using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BLL;
using Microsoft.Win32;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DAL
{
    public class Conexion
    {
        //objetos para interactuar con la base de datos
        private string StringConexion;
        private SqlConnection connection;
        private SqlDataReader reader;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataSet dataset;

        //constructor por omision
        public Conexion()
        {
            //config del sitio
            this.StringConexion = "Data source=LAPTOP-G169758G\\SQLEXPRESS;initial catalog=DbControlSalarios;User Id=UserCalcularSalarios;password=123456";
        }


        public void GUardarUsuario(Operaciones pUser)
        {
            try
            {

                //se debe instanciar la conexion
                this.connection = new SqlConnection(this.StringConexion);
                //abrir conexion
                this.connection.Open();
                //se instancia el comando
                this.command = new SqlCommand();
                //se asigna la conexion al comando
                this.command.Connection = this.connection;
                //tipo de comando
                this.command.CommandType = CommandType.StoredProcedure;
                //nombre del procedimiento
                this.command.CommandText = "[Sp_Ins_Pagos]";
                //se asignan los datos 
                this.command.Parameters.AddWithValue("@pNombreCompleto", pUser.Nombre);
                this.command.Parameters.AddWithValue("@pCedula", pUser.Cedula);
                this.command.Parameters.AddWithValue("@pHorasNormales", pUser.horasnormales);
                this.command.Parameters.AddWithValue("@pHorasExtra", pUser.horasExtra);
                this.command.Parameters.AddWithValue("@pSalarioBruto", pUser.CalcularSalario());
                this.command.Parameters.AddWithValue("@pDeducciones", pUser.calcularDeducciones());
                this.command.Parameters.AddWithValue("@pSalarioNeto", pUser.CalcularSalarioNeto());

                //se ejecuta el comando
                this.command.ExecuteNonQuery();

                this.connection.Close();
                this.connection.Dispose();
                this.command.Dispose();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Operaciones BuscarBoletaPago(string pCedula)
        {
            Operaciones ObjPago = new Operaciones();
            try
            {
                //instanciar la conexion
                this.connection = new SqlConnection(this.StringConexion);

                //se intenta abrir
                this.connection.Open();

                //instancia comando
                this.command = new SqlCommand();

                //asigna la conexion
                this.command.Connection = this.connection;

                //se indica el tipo de comando  ejecuta un procedimiento almacenado
                this.command.CommandType = CommandType.StoredProcedure;

                //se debe indicar el procedimiento almacenado
                this.command.CommandText = "[Sp_Cns_Pago]";

                //si el procedimiento almacenado tiene parametros es muy importante darle los valores
                this.command.Parameters.AddWithValue("@Cedula", pCedula);

                //ejecucion de lectura de datos
                this.reader = this.command.ExecuteReader();
                //se pregunta si se puede leer o tiene datos
                if (this.reader.Read())
                {

                    ObjPago.Nombre = this.reader.GetValue(0).ToString();
                    ObjPago.Cedula = int.Parse(this.reader.GetValue(1).ToString());
                    ObjPago.horasnormales = double.Parse(this.reader.GetValue(2).ToString());
                    ObjPago.horasExtra = double.Parse(this.reader.GetValue(3).ToString());
                    ObjPago.SalarioBruto = double.Parse(this.reader.GetValue(4).ToString());
                    ObjPago.Deducciones = double.Parse(this.reader.GetValue(5).ToString());
                    ObjPago.SalarioNeto = double.Parse(this.reader.GetValue(6).ToString());

                }
                else
                {
                    new Exception("No existe ese usuario");
                    return null;
                }

                //es muy importante siempre despues de la transaccion cerrar la conexion
                this.connection.Close();
                this.connection.Dispose();
                this.command.Dispose();

                return ObjPago;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }









    }//fin de la clase 


}
