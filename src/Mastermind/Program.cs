using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mastermind
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Random zufi = new Random();
            //int[] counter = new int[6];
            //for (int i = 0; i < 100; i++)
            //{
            //    int zahl = zufi.Next(1, 7);
            //    counter[zahl - 1]++;
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine("Anzahl " + (i + 1).ToString() + ": " + counter[i].ToString());
            //}
            //Console.ReadLine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
