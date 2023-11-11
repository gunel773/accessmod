using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access1.Models
{
    internal class Computer
    {
        readonly string color = "red"; //class icinde set elemek olr ve construktorda
        public string Model;
        private int _ram;
        protected int Memorage;
        public int Ram
        {
            get
            {
                return _ram;
            }
            set
            {
                _ram = Ram;
            }
        }

        public Computer(string model, int ram, int memorage, string color)
        {
            model = Model;
            memorage = Memorage;
            ram = _ram;
            color = "green";
        }


        public void Info()
        {
            Console.WriteLine(Model,Memorage,_ram);
        }
            
        
         
    }
}
