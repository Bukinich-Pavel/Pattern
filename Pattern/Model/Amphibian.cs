using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Model
{
    class Amphibian : IAnimal
    {
        public string KindAnimal { get; set; }

        public Amphibian(string kindAnimal)
        {
            this.KindAnimal = kindAnimal;
        }

        public override string ToString()
        {
            return $"Земноводное - {KindAnimal} ";
        }

    }
}
