using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Model
{
    internal class Car
    {
        string type;  //тип автомобиля
        public string Type => type;

        int avg_cons; //средний расход на 100км
        public int Avg_cons => avg_cons;

        int fuel_t; //ёмкость бака
        public int Fuel_t => fuel_t;

        int speed; //средняя (крейсерская) скорость
        public int Speed => speed;
    }
}
