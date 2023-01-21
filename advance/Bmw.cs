using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace advance
{
    internal class Bmw : Car
    {
        private string brand="Bmw";

        public string Model { get; set; }

        public Bmw(int hp,string color,string model ):base(hp,color)
        {

            this.Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Brand" + brand+"Hp: " + Hp + " " + "Color: " + Color);
            Console.ReadLine();
        }

        public override void Repair()
        {
            Console.WriteLine("The Bmw car was repaired",Model);
            Console.ReadLine();
        }


    }
}
