using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Personas
    {
        string[] nombre;
        int [] edad;
        string [] sexo;

        public string[] Nombre { get => nombre; set => nombre = value; }
        public int[] Edad { get => edad; set => edad = value; }
        public string[] Sexo { get => sexo; set => sexo = value; }

        public int sumaEdad()
        {
            int suma = 0;

            for (int i = 0; i < edad.Length; i++)
                suma += edad[i];

            return suma;
        }

        public double promEdad()
        {
            return sumaEdad()/edad.Length;
        }

        public int indexmayorEdad()
        {
            int may = 0, index=0;

            may = Edad[0];

            for (int i = 0; i < edad.Length; i++)
                if (may<edad[i])
                {
                    may=edad[i];
                    index = i;
                }
                    

            return index;
        }

        public int indexmenorEdad()
        {
            int men = 0, index = 0;

            men = edad[0];

            for (int i = 0; i < edad.Length; i++)
                if (men > edad[i])
                {
                    men = edad[i];
                    index = i;
                }

            return index;
        }

        public int numProfMayProm()
        {
            int cpmayp=0;

            for (int i = 0; i < edad.Length; i++)
                if (edad[i]> promEdad())
                      cpmayp++;
                

            return cpmayp;
        }

        public int numProfMenProm()
        {
            int cpmenp = 0;

            for (int i = 0; i < edad.Length; i++)
                if (edad[i] > promEdad())
                    cpmenp++;


            return cpmenp;
        }

        public string nPrfmasJoven()
        {
            return nombre[indexmenorEdad()];
        }

        public string nPrfmasConMayor()
        {
            return nombre[indexmayorEdad()];
        }
    }
}
