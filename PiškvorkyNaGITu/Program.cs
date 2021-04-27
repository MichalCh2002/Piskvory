using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiškvorkyNaGITu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*tets*/
            Application.Run(new Form1());

        }

        //pole pro mrizku piskvorek
        static int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
        static int player = 1;  //hrac
        static int choice;  //pozice vyberu hrace

        static int flag = 0;    //promenna pro identifikaci viteze



    }
}
