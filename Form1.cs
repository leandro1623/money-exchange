using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cambio
{
    public partial class Form1 : Form
    {
        private long DosMil, Mil, Quinientos, Docientos, Cien, Cincuenta, Venticinco, Diez, Cinco, Pesos;

        public Form1()
        {            
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {

            btn_Cambiar.Enabled = false;
            EstablecerFecha();

            //estableciendo valores en 0
            DosMil = Mil = Quinientos = Docientos = Cien = Cincuenta = Venticinco = Diez = Cinco = Pesos = 0;

            //estabelciendo valores de la pantalla en 0
            _Dos_Mil.Text = DosMil.ToString();
            _Mil.Text = Mil.ToString();
            _Quinientos.Text = Quinientos.ToString();
            _Doscientos.Text = Docientos.ToString();
            _Cien.Text = Cien.ToString();
            _Cincuenta.Text = Cincuenta.ToString();
            _VenteYcinco.Text = Venticinco.ToString();
            _Diez.Text = Diez.ToString();
            _Cinco.Text = Cinco.ToString();
            _Pesos.Text = Pesos.ToString();

        }

        private void Cambiar()
        {

            long cantidad;
            if (long.TryParse(TextBox.Text, out cantidad))
            {
                long.TryParse(TextBox.Text,out cantidad); 
            }
            else
            {
                MessageBox.Show("Los caracteres digitados no tienen el formato correcto, porfavor solo digite numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
            }
                
            Cambio(cantidad);

            //asignando valores
            _Dos_Mil.Text = DosMil.ToString();
            _Mil.Text = Mil.ToString();
            _Quinientos.Text = Quinientos.ToString();
            _Doscientos.Text = Docientos.ToString();
            _Cien.Text = Cien.ToString();
            _Cincuenta.Text = Cincuenta.ToString();
            _VenteYcinco.Text = Venticinco.ToString();
            _Diez.Text = Diez.ToString();
            _Cinco.Text = Cinco.ToString();
            _Pesos.Text = Pesos.ToString();

            EstablecerFecha();
        }

        private void Cambio(long Cantidad)
        {
            DosMil = Cantidad / 2000;
            Cantidad %= 2000;
            Mil = Cantidad / 1000;
            Cantidad %= 1000;
            Quinientos = Cantidad / 500;
            Cantidad %= 500;
            Docientos = Cantidad / 200;
            Cantidad %= 200;
            Cien = Cantidad / 100;
            Cantidad %= 100;
            Cincuenta = Cantidad / 50;
            Cantidad %= 50;
            Venticinco = Cantidad / 25;
            Cantidad %= 25;
            Diez = Cantidad / 10;
            Cantidad %= 10;
            Cinco = Cantidad / 5;
            Cantidad %= 5;
            Pesos = Cantidad / 1;
            Cantidad %= 1;
            EstablecerFecha();
        }

        private void EstablecerFecha()
        {
            DateTime FechaActual = new DateTime();
            FechaActual = DateTime.Now;
            Fecha.Text = FechaActual.ToString();
        }

        //------------------------------
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            btn_Cambiar.Enabled = string.IsNullOrEmpty(TextBox.Text) ? false : true ;
            EstablecerFecha();
        }

        private void btn_Cambiar_Click(object sender, EventArgs e)
        {
            EstablecerFecha();
            Cambiar();
        }
        private void Fecha_Click(object sender, EventArgs e)
        {
            EstablecerFecha();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
