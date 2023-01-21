using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advance
{
    internal class Car
    {
        public int Hp { get; set; }
        public string Color { get;set; }

        public Car (int hp, string color)
        {
            this.Hp = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Hp: " + Hp +" "+"Color: "+ Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("car was repaired");
        }

    }
}
