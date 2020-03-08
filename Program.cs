using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car oldcar = new Car();
            oldcar.Go();
            oldcar.GoCarefully();
        }
    }

    public class Car
    {
        public int wheels;

        public int speed;

        public string name;

        [Obsolete("Метод устарел. Не используйте!!!", false)]
        public void Go()
        {
            Console.WriteLine("Car Go");
        }

        [Obsolete("Метод нельзя использовать. Не используйте!!!", true)]
        public void GoCarefully()
        {
            Console.WriteLine("Car Go slowly with 0km/h");
        }


    }
}
