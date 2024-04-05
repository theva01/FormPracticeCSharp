using System;
using System.Collections;
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

            //ArrayList lista = new ArrayList();//Arreglo dianmico antiguo

            //lista.Add("LabelEditEventArgs");
            //lista.Add(32232);
            //lista.Add(lista.ToArray());
            //lista.Add(333);

            

            List<int> lista2 = new List<int>();

            lista2.Add(222112);
            lista2.Add(32232);
            lista2.Add(332222234);
            lista2.Add(333);

            foreach (var i in lista2)
            {
                MessageBox.Show(i.ToString());
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
