using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Model
{
    internal class Car_Metod
    {

        public int DistanceToStop(Car car, int fuel) //расстояние которое машина может преодолеть на текущем запасе топлива.
        {
            int distanceToStop = 0;
            if (fuel > car.Fuel_t)
            {
                fuel = car.Fuel_t;
            }
            if (fuel < 0)
            {
                fuel = 0;
            }
            distanceToStop = fuel / car.Avg_cons * 100;
            return distanceToStop;
        }

        public double DistanceToStopWith(Car car, int fuel, byte weight) //расстояние которое машина может преодолеть на текущем запасе топлива с учётом пассажирова или груза в зависимости от типа машины 
        {
            double distanceToStop = 0;
            int distanceToStopNom = DistanceToStop(car, fuel);

            if (car is Light_Car)
            {
                distanceToStop = distanceToStopNom - (distanceToStopNom * weight * 0.06);
            }
            else
                distanceToStop = distanceToStopNom - (distanceToStopNom * (weight/0.2) * 0.04);

            return distanceToStop;
        }

        public double DistanceTime(Car car, double distance) //время за которое машина преодолеет заданное расстояние 
        {
            double distanceTime = distance / car.Speed;
            return distanceTime;
        }
    }
}
