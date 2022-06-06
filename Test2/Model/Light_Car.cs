using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Model
{
    internal class Light_Car : Car
    {
        [Required]
        [Range (1, 7)]
        public int MaxPass { get; set; } //максимальное количество пассажиров. Ограничено 7, т.к. больше это уже автобус

        public Light_Car(int maxPass)
        {
            MaxPass = maxPass;  
        }

        int passengers;
        public int Passangers  //текущее количество пассажиров
        {
            set
            {
                if (value <= MaxPass)
                {
                    passengers = value;
                }
            }
            get { return passengers; }
        }   
    }
}
