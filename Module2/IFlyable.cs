using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public interface IFlyable
    {
        public void Fly();
    }

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    public class Airplane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Airplane is flying");
        }
    }
}
