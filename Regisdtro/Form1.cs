using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regisdtro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int Contador;
        static int contador;

        Func<string> generarNumero = () =>
        {
            Contador++;
            return Contador.ToString("00");

        };

        Func<int> contar = () =>
        {
            int contador =1;
            contador++;
            return contador;
        };
        
        int getNumeros()
        {
            return Contador;
        }

        // Capturar valores//

        int getNumero()
        {
            return int.Parse(lblNumero.Text);
        }

        string getNombre()
        {
            return txtNombre.Text;
        }

        double getEdad()
        {
            return double.Parse(txtEdad.Text);

        }

        string getSexo()
        {
            return cbSexo.Text;
        }


        Func<string, double, double> TotalEdades = (Sexo, edad) =>
        {
            double descuento = 0;
            switch (Sexo)
            {
                case "Masculino": descuento = edad; break;

                case "Femenino": descuento = edad; break;
            }

            return descuento;

        };



        Func<int, int, int> CalcularPromedioEdad = (totaledad, Contador) => totaledad / contador;



        string Mujermayor()
        {
            int mayor = int.Parse(lvRegistroMaestro.Items[0].SubItems[3].Text);
            int posicion = 0;

            for (int i = 0; i < lvRegistroMaestro.Items.Count; i++)
            {
                if (int.Parse(lvRegistroMaestro.Items[i].SubItems[3].Text) > mayor)
                {
                    posicion = i;
                }

            }
            return lvRegistroMaestro.Items[posicion].SubItems[1].Text;
        }


        string HombreMenor()
        {
            int Menor = int.Parse(lvRegistroMaestro.Items[0].SubItems[3].Text);
            int posicion = 0;

            for (int i = 0; i < lvRegistroMaestro.Items.Count; i++)
            {
                if (int.Parse(lvRegistroMaestro.Items[i].SubItems[3].Text) < Menor)
                {
                    posicion = i;
                }

            }
            return lvRegistroMaestro.Items[posicion].SubItems[1].Text;
        }

        void imprimirRegistro(double descuento, double precioVenta)
        {
            ListViewItem fila = new ListViewItem(getNumero().ToString());

            fila.SubItems.Add(getNombre());
            fila.SubItems.Add(getSexo());
            fila.SubItems.Add(getEdad().ToString());


            lvRegistroMaestro.Items.Add(fila);
        }

        void imprimirEstadisticas(int promEdad, string MujerMayor, string HombreMenor, int MujerMP, int HombremP)
        {
            lvInformacion.Items.Clear();

            string[] elementosFila = new string[2];
            ListViewItem row;

            elementosFila[0] = "Edad Promedio: ";
            elementosFila[1] = promEdad.ToString();

            row = new ListViewItem(elementosFila);

            lvInformacion.Items.Add(row);


            elementosFila[0] = "La Mujer con Mayor Edad:";
            elementosFila[1] = MujerMayor;
            row = new ListViewItem(elementosFila);
            lvInformacion.Items.Add(row);

            elementosFila[0] = "El Hombre Joven:";
            elementosFila[1] = HombreMenor;
            row = new ListViewItem(elementosFila);
            lvInformacion.Items.Add(row);

            elementosFila[0] = "Cantidad de Mujer Con Edad Mayor al Promedio:";
            elementosFila[1] = MujerMP.ToString();
            row = new ListViewItem(elementosFila);
            lvInformacion.Items.Add(row);

            elementosFila[0] = "Cantidad de Hombres Con Edad Menor al Promedio:";
            elementosFila[1] = HombremP.ToString();
            row = new ListViewItem(elementosFila);
            lvInformacion.Items.Add(row);
        }

        string Valida()
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                txtNombre.Focus();
                return "Nombre del Maestro";

            }
            else if (cbSexo.SelectedIndex == -1)
            {
                cbSexo.Focus();
                return "Sexo del Maestro";

            }
            else if (txtEdad.Text.Trim().Length == 0)
            {
                txtEdad.Focus();
                return "Edad del Maestro";

            }
            return "";
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

            if (Valida() == "")
            {
                double edad = getEdad();
                string genero = getSexo();

                int prom = CalcularPromedioEdad(Contador, Contador);

                imprimirRegistro(Contador, Contador);
                lblNumero.Text = generarNumero();

            }
            else
            {
                MessageBox.Show("porfavor ingresar " +Valida());
            }
        }


    }
}
