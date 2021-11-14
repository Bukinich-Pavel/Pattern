using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Model
{
    class Bird : IAnimal
    {
        public int Id { get; set; }
        public string KindAnimal { get; set; }
        public bool CanFly { get; set; }

        public Bird(string kindAnimal)
        {
            this.KindAnimal = kindAnimal;
        }

        public override string ToString()
        {
            string canfly = CanFly ? "Умеет летать" : "Не умеет летать";
            return $"Птица - {KindAnimal} - {canfly}";
        }
    }
}
