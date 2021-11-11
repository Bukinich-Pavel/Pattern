using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern.Model;

namespace Pattern.Save
{
    interface IAnimalSave
    {
        void SaveAllAnimal(StringBuilder animals);
    }
}
