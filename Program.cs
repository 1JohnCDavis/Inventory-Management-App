using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace John_Davis_Inventory_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Inventory.AllParts.Add(new Inhouse(0, "Wheel", 12.11m, 15, 5, 25, 100));
            Inventory.AllParts.Add(new Inhouse(1, "Pedal", 8.22m, 11, 5, 25, 110));
            Inventory.AllParts.Add(new Outsourced(2, "Chain", 8.33m, 12, 5, 25, "AAA"));
            Inventory.AllParts.Add(new Outsourced(3, "Seat", 4.55m, 8, 2, 15, "BBB"));

            Inventory.Products.Add(new Product(0, "Red Bicycle", 11.44m, 15, 1, 25));
            Inventory.Products.Add(new Product(1, "Yellow Bicycle", 9.66m, 19, 1, 20));
            Inventory.Products.Add(new Product(2, "Blue Bicycle", 12.77m, 5, 1, 25));
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
