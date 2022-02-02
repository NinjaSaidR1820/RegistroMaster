using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[] nom;
        int[] eda;
        string [] sex;

        int n=0, ed=0, se=0;

        Personas p;
        public Form1()
        {
            InitializeComponent();
            p=new Personas();
        }

        private void txtPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                nom = new string[int.Parse(txtPersonas.Text)];
                eda = new int[int.Parse(txtPersonas.Text)];
                sex = new string[int.Parse(txtPersonas.Text)];

                txtNombre.Focus();
            }
        }

        private void nudEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                eda[ed] = int.Parse(nudEdad.Value.ToString());
                ed++;
                optFemenino.Focus();


                
            }
        }

        private void optFemenino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                sex[se] = "Femenino";

                //lvDatos.Items.Clear();
                string[] elementosFila = new string[3];
                ListViewItem row;

                elementosFila[0] = nom[se];
                elementosFila[1] = eda[se].ToString();
                elementosFila[2] = sex[se];
                row = new ListViewItem(elementosFila);
                lvDatos.Items.Add(row);

                se++;
                txtNombre.Focus();
                txtNombre.Clear();
                nudEdad.Value = 0;

                if (se == int.Parse(txtPersonas.Text))
                {
                    p.Nombre = nom;
                    p.Edad = eda;
                    p.Sexo = sex;

                    MessageBox.Show("DATOS INGRESADOS...");
                    btnResultados.Focus();
                }
                    



            }
        }

        private void optMasculino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                sex[se] = "Masculino";

                //lvDatos.Items.Clear();
                string[] elementosFila = new string[3];
                ListViewItem row;

                elementosFila[0] = nom[se];
                elementosFila[1] = eda[se].ToString();
                elementosFila[2] = sex[se];
                row = new ListViewItem(elementosFila);
                lvDatos.Items.Add(row);

                se++;
                txtNombre.Focus();
                txtNombre.Clear();
                nudEdad.Value = 0;

                if (se == int.Parse(txtPersonas.Text))
                {
                    p.Nombre = nom;
                    p.Edad = eda;
                    p.Sexo = sex;

                    MessageBox.Show("DATOS INGRESADOS...");
                    btnResultados.Focus();
                }




            }
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            txtResultados.Text = "\r\nEdad promedio : "+ p.promEdad() + "\r\nProfesor mas joven :"
                + p.nPrfmasJoven() + "\r\nProfesor con mayor edad :" +p.nPrfmasConMayor();
        }

        private void txtResultados_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                nom[n]= txtNombre.Text;
                n++;
                nudEdad.Focus();


                
            }
        }
    }
}
