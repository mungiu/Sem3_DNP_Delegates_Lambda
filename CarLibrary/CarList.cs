using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class CarList<T>
    {
        public List<T> carList;
        public CarList()
        {
            carList = new List<T>();
        }
    }
}
