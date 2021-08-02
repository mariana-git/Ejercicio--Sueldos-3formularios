using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sueldos_3formularios_

{
    public partial class Form1 : Form

        //Actividad: Realizar un ejercicio que permita vincular tres formularios en los cuales se mostrara el sueldo de un empleado.
        //En el primer formulario se ingresa el nombre del empleado, el sueldo, el premio (en porcentaje), y el salario por familiar;
        //este formulario tendrá 3 botones: uno de salida, otro de limpiar y otro que indique ir al segundo formulario.
    {
        //Declaro públlicas las variables para utilizarlas en en el tercer formulario
        public static string Nombre;
        public static string Sueldo;
        public static string Premio;
        public static string Salario;

        public Form1()
        {
            InitializeComponent();
            txtNombre.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
        // Limpio el formulario con el metodo de la clase UTILES:
            var Util = new Utiles();
            Util.LimpiarFormulario(this);
        }
        // Hago que los txtbox admitan solo letras o numeros con los metodos de la clase UTILES:
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            var letras = new Utiles();
            letras.SoloLetras(e);
        }
        private void TxtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numeros = new Utiles();
            numeros.SoloNumeros(e);
        }

        private void TxtPremio_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numeros = new Utiles();
            numeros.SoloNumeros(e);
        }

        private void TxtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            var numeros = new Utiles();
            numeros.SoloNumeros(e);
        }

        public void BtnSiguiente2_Click(object sender, EventArgs e)
        {
            //realizo un control de que se complete el nombre del empleado
            if (txtNombre.Text == string.Empty) ErrPrvNombre.SetError(txtNombre, "Indique Nombre");
            else
            {
                //si el campo de nombre de empleado ya esta completo, ejecuto el resto del código

            
                //recorro los controles colocando 0 en los textbox que estén vacíos
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Text == string.Empty)
                        {
                            c.Text = "0";
                        }
                    }
                }            
                //Este botón redirige al formulario 2 y pasa los datos cargados
                double sueldo = Convert.ToDouble(txtSueldo.Text);
                double premio = (sueldo*(Convert.ToDouble(txtPremio.Text)/100));
                double salario = Convert.ToDouble(txtSalario.Text);

                //cargo las variables globales con los valores de los txtbox para usarlos en el form3
                Nombre = txtNombre.Text;
                Sueldo = txtSueldo.Text;
                Premio = $"{premio}";
                Salario = txtSalario.Text;

                Form2 formulario2 = new Form2(sueldo,premio,salario);
                formulario2.Show();
                //limpio el error provider
                ErrPrvNombre.Clear();
            }
        }
    }
}
