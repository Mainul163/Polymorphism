using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance
{
    internal class Audi : Car
    {
        private string brand = "Audi";

        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {

            this.Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Brand" + brand + "Hp: " + Hp + " " + "Color: " + Color);
            Console.ReadLine();
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi car was repaired", Model);
            Console.ReadLine();
        }

    }
}
