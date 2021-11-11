using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern.Model;

namespace Pattern.Save
{
    class AnimalWriter
    {
        public IAnimalSave AnimalSave { get; set; }
        public List<IAnimal> Animals { get; set; }

        public AnimalWriter(IAnimalSave animalSave, IEnumerable<IAnimal> animals)
        {
            this.AnimalSave = animalSave;
            this.Animals = animals.ToList();
        }

        public void Save()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Animals)
            {
                sb.AppendLine(item.ToString());
            }

            AnimalSave.SaveAllAnimal(sb);
        }
    }
}
