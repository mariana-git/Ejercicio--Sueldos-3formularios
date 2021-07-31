using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Sueldos_3formularios_
{
    class Utiles
    {
        public void LimpiarFormulario(Form formulario)
        {
            //recorro los controles limpiando el formulario
            if (formulario is null)
            {
                throw new ArgumentNullException(nameof(formulario));
            }

            foreach (Control control in formulario.Controls)
            {
                if (control is TextBox) control.Text = "";
                if (control is ComboBox) ((ComboBox)control).SelectedIndex = -1;
                if (control is CheckBox) ((CheckBox)control).Checked = false;
                if (control is GroupBox | control is Panel)
                {
                    foreach (Control controlGrup in control.Controls)
                    {
                        if (controlGrup is TextBox) controlGrup.Text = "";
                        if (controlGrup is ComboBox) ((ComboBox)controlGrup).SelectedIndex = -1;
                        if (controlGrup is CheckBox) ((CheckBox)controlGrup).Checked = false;
                    }
                }
            }
        }
        public bool SoloNumeros(KeyPressEventArgs e)
        {
            //solo permito el ingreso de numeros y comas (SE LLAMA DESDE EL KEYPRESS)
            if (char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar) | char.ToString(e.KeyChar) == ",") e.Handled = false;
            else e.Handled = true;
            return e.Handled;
        }
        public bool SoloLetras(KeyPressEventArgs e)
        {
            //solo permito el ingreso de letras y espacio (SE LLAMA DESDE EL KEYPRESS)
            if (char.IsLetter(e.KeyChar) | char.IsControl(e.KeyChar) | char.IsWhiteSpace(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
            return e.Handled;
        }
    }
}
