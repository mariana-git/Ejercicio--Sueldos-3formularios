using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sueldos_3formularios_
{
    public partial class Form2 : Form
    {
        //En el segundo formulario se mostraran directamente los valores de los descuentos efectuados y total que cobra el empleado,
        //estos se calcularan a través de las siguientes formulas:
        ////Descuento = (sueldo + premio) x 0,2 ;
        //Total a cobrar = sueldo + premio + salario – descuento.
        //En dicho formulario se deberá colocar dos botones: uno de cancelar, que enviara al usuario al primer formulario y contendrá
        //los datos que ingreso anteriormente y uno de siguiente que lo llevara al tercer formulario

        //declaro dos variables globales más para usar en el form3
        public static string Descuento;
        public static string Total;
        public Form2(double sueldo, double premio, double salario)
        {
            InitializeComponent();
           
            double descuento = (sueldo + premio) * 0.2;
            double total = sueldo + premio + salario - descuento;
            

            lblDescuento.Text = $"{descuento}";
            lblTotal.Text = $"{total}";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void btnSiguiente3_Click(object sender, EventArgs e)
        {
            //asigno a las variables globales los valores obtenidos
            Descuento = lblDescuento.Text;
            Total = lblTotal.Text;

            Form3 formulario3 = new Form3();
            formulario3.Show();

            Close();
        }
    }
}
