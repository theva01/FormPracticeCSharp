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

            int[] numeros = { 1, 2, };
            int[] numeros2 = new int[7];

            numeros2[0] = 1;
            numeros2[1] = 233;
            numeros2[2] = 334;
            numeros2[3] = 0;
            numeros2[4] = 443;
            numeros2[5] = 0;
            numeros2[6] = 436;

            MessageBox.Show(numeros2[4].ToString());
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
