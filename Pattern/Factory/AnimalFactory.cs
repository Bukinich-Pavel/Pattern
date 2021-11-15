using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern.Model;

namespace Pattern.Factory
{
    static class AnimalFactory
    {
        public static IAnimal GetAnimal(string typeAnimal, string kindAnimal)
        {
            switch (typeAnimal)
            {
                case "Птица": return new Bird(kindAnimal);
                case "Земноводное": return new Amphibian(kindAnimal);
                case "Млекопитающее": return new Mammal(kindAnimal);
                default: return new NullAnimal();
            }
        }
    }
}
