using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationApp
{
    public class Car   // Car nesnelerinin tanımlanması ||Identifying car objects
    {
        private int _NumberofDoors;
        public string Mark { get; set; }
        public string Model { get; set; }  
        public string Colour { get; set; }
        public int NumberofDoors
        {
        get { return _NumberofDoors; }
            set 
            { 
                if (value == 2 || value == 4)
                {
                    _NumberofDoors = value;
                }
                else
                {
                    Console.WriteLine("Yanlış kapı sayısı girdiniz. Sadece 2 veya 4 kapılı araba üretilir. Kapı değeri -1 olarak gösterilecektir.");
                    _NumberofDoors = -1;
                }
            }
        }
        public Car(string mark, string model, string colour, int _numberofdoors)
        {
            Mark = mark;
            Model = model;
            Colour = colour;
            NumberofDoors = _numberofdoors;
        }

    }
    
}
