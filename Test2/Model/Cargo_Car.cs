using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Model
{
    internal class Cargo_Car
    {
        [Required]
        [Range(2, 50)]
        public int MaxWeight { get; set; } //максимальный груз. Ограничен 50 тоннами.

        public Cargo_Car(int maxWeight)
        {
            MaxWeight = maxWeight;
        }

        int weight; //текщая загрузка автомобиля
        public int Wight 
        {
            set
            {
                if (value <= MaxWeight)
                {
                    weight = value;
                }
            }
            get { return weight; }
        }
    }
}
