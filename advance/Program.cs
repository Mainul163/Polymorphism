namespace advance
{
    internal class Program

    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Bmw(200,"Red","A3"),
                new Audi(300,"Green","Z3")
            };
            
            foreach(var car in cars)
            {
                car.Repair();
            }
            Console.ReadLine();

        }
       

    }
  
}