using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone
{
    public interface Clone
    {
        public Clone clone();
    }
    abstract public class Transport:Clone
    {
        public Transport() { }
        public Transport(string name, double price, Engine engine)
        {
            this.name = name;
            this.price = price;
            this.engine = engine;
        }
        public Transport(Transport origin) 
        {
            this.name = origin.name; 
            this.price = origin.price; 
            this.engine = origin.engine;
        }
        public Clone clone()
        {
            return new Transport(this);
        }
        protected string name;
        public double price;
        public Engine engine;
    }

    public class Engine: Clone
    {
        public Engine() { }
        public Engine(int power, string fuelType)
        {
            Power = power;
            FuelType = fuelType;
        }
        public Engine(Engine engine)
        {
            this.FuelType = engine.FuelType;
            this.Power = engine.Power;
        }
        public Clone clone()
        {
            return new Engine(this);
        }
        public int Power;
        string FuelType;
        
    }
}
