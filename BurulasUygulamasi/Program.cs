using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurulasUygulamasi.Forms;

namespace BurulasUygulamasi
{
    internal static class Program
    {
        public static Yolcu AktifYolcu { get; set; } = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaForm());
        }
    }
}
