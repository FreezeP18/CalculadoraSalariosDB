using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Operaciones
    {
        public double planilla;
        public int Cedula { get; set; }
        public string Nombre { get; set; }

        public double horasnormales { get; set; }

        public double horasExtra { get; set; }

        public double planilla3 { get; set; }

        public double SalarioBruto { get; set; }

        public double Deducciones { get; set; }

        public double SalarioNeto { get; set; }

        public double CalcularSalario()
        {
            double salarioBruto = (this.horasnormales * 1800) + (this.horasExtra * 2700);
            return salarioBruto;
        }

        public double calcularDeducciones()
        {
            double salarioBruto = CalcularSalario();
            double deduccion = 0;

            if (salarioBruto <= 250000)
            {
                deduccion = salarioBruto * 0.09;
            }
            else if (salarioBruto <= 380000)
            {
                deduccion = salarioBruto * 0.12;
            }
            else
            {
                deduccion = salarioBruto * 0.15;
            }

            return deduccion;
        }

        public double CalcularSalarioNeto()
        {
            double salarioNeto = 0;
            salarioNeto = CalcularSalario() - calcularDeducciones();
            return salarioNeto;
        }

        public double Calcularplanilla(double planilla2)
        {
            planilla = planilla + planilla2;



            return planilla;
        }









    }


}
