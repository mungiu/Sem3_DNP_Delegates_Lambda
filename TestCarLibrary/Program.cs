using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCarLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLibrary.Car car = new CarLibrary.Car(1, 1, 1);
            CarLibrary.Car car1 = new CarLibrary.Car(2, 3, 3);
            CarLibrary.CarList<CarLibrary.Car> carLibrary = new CarLibrary.CarList<CarLibrary.Car>();

            carLibrary.carList.Add(car1);
            carLibrary.carList.Add(car);
            carLibrary.carList.Sort();

            foreach(CarLibrary.Car _car in carLibrary.carList)
            {
                Console.WriteLine(_car);
            }

            Console.ReadKey();
        }
    }
}
