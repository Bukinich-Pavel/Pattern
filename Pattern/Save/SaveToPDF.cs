using Pattern.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Save
{
    class SaveToPDF : IAnimalSave
    {
        string nameFile;

        public SaveToPDF(string nameFile)
        {
            this.nameFile = nameFile;
        }

        public void SaveAllAnimal(StringBuilder animals)
        {
            using (StreamWriter sw = new StreamWriter($"{nameFile}.pdf"))
            {
                sw.WriteLineAsync(animals);
            }

        }
    }
}
