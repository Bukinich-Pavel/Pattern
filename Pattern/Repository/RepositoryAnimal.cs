using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern.Model;
using WriterLibrary;

namespace Pattern.Repository
{
    class RepositoryAnimal
    {
        List<IAnimal> animals;

        public RepositoryAnimal()
        {
            animals = new List<IAnimal>();
        }

        public RepositoryAnimal(IEnumerable<IAnimal> animals)
        {
            this.animals = animals.ToList();
        }

        public void Add(IAnimal animal)
        {
            animals.Add(animal);
        }

        public List<IAnimal> GetAll()
        {
            return animals;
        }

        public void Save(string nameFile)
        {
            SaveToPDF saveToPDF = new SaveToPDF($"{nameFile}");
            Writer<IAnimal> writer = new Writer<IAnimal>(saveToPDF, animals);
            writer.Save();

        }

    }
}
