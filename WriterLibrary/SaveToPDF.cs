using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriterLibrary
{
    public class SaveToPDF : ISave
    {
        string nameFile;

        public SaveToPDF(string nameFile)
        {
            this.nameFile = nameFile;
        }

        public void SaveAll(StringBuilder strings)
        {
            using (StreamWriter sw = new StreamWriter($"{nameFile}.pdf"))
            {
                sw.WriteLineAsync(strings);
            }

        }
    }
}
