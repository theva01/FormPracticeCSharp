using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            #region Primer turotial Csharp en consola
            // string Nombre = "Anderson";

            // int num1 = 450444;
            // uint num2 = 500; //uint nunca valor negativo
            // float num3 = 99.3f;// f indica numero flotante (mas precision decimal)
            // double num4 = 22.43;// nuemro decimal mas grande que float
            // decimal num5 = 7983456.974323m;//m indica decimal (calculos gigantes)
            // byte num6 = 255;//maximo 255

            //// MessageBox.Show(Nombre);
            // //MessageBox.Show(num3.ToString());//Conversion

            // bool acceso = true;
            //// MessageBox.Show(acceso.ToString());

            // DateTime fecha = DateTime.Now;
            // //MessageBox.Show(fecha.ToShortDateString().ToString());

            // //int num7 = 43;
            // //int num8 = 50;
            // //int num9 = 100;
            // //int num10 = 200;
            // //int num12 = 500;mucho espacio vertical para crear variables

            // int num7, num8, num9, num10, num11;
            // num7 = 39; num8 = 33; num9 = 213; num10 = 100; num11 = 104;

            // const string dato = "Hola puebas constante";
            // //dato = "cambio constante";
            // MessageBox.Show(dato);
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
