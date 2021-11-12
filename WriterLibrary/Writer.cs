using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriterLibrary
{
    public class Writer<T>
    {
        public ISave SaveMethod { get; set; }
        public List<T> Collection { get; set; }

        public Writer(ISave saveMethod, IEnumerable<T> collection)
        {
            this.SaveMethod = saveMethod;
            this.Collection = collection.ToList();
        }

        public void Save()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Collection)
            {
                sb.AppendLine(item.ToString());
            }

            SaveMethod.SaveAll(sb);
        }
    }
}
