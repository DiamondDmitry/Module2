using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public interface IElectronicDevice
    {
        public void TurnOn();
        public void TurnOff();
    }

    public class TV : IElectronicDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("TV is OFF");
        }

        public void TurnOn()
        {
            Console.WriteLine("TV is OF");
        }
    }

    public class Laptop : IElectronicDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("Laptop is OFF");
        }

        public void TurnOn()
        {
            Console.WriteLine("Laptop is ON");
        }
    }
}
