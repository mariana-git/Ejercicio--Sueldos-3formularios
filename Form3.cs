using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sueldos_3formularios_
{
    public partial class Form3 : Form
    {

        // En este formulario se mostraran los valores del recibo de sueldo: Nombre del empleado, sueldo, premio, salario, descuento,
        //total a cobrar, y tendrá un botón que indique volver al primer formulario, donde deberán mostrarse todos los campos vacios.
        public Form3()
        {
            InitializeComponent();


            lblNombre.Text = Form1.Nombre;
            lblSueldo.Text = Form1.Sueldo;
            lblPremio.Text = Form1.Premio;
            lblSalario.Text = Form1.Salario;
            lblDescuento.Text = Form2.Descuento;
            lblTotal.Text = Form2.Total;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
