using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Model
{
    class NullAnimal : IAnimal
    {
        public string KindAnimal { get; set; }

        public NullAnimal()
        {
            KindAnimal = "Нет названия";
        }
    }
}
