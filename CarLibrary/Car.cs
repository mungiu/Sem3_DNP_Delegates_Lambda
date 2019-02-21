using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car : IComparable<Car>
    {
        int engineSize;
        int topSpeed;
        double weight;

        public Car(int engineSize, int topSpeed, double weight)
        {
            this.engineSize = engineSize;
            this.topSpeed = topSpeed;
            this.weight = weight;
        }

        public int CompareTo(Car other)
        {
            if (this.engineSize > other.engineSize)
                return 1;
            else if (this.engineSize == other.engineSize)
                return 0;
            else if (this.engineSize < other.engineSize)
                return -1;
            else return 0;
        }

        public override string ToString()
        {
            string str = $"Engine size is {engineSize} and top speed is {topSpeed}.";
            return str;
        }
    }
}
