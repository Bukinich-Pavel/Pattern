using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public interface IView
    {
        public IEnumerable BirdTable { get; set; }
        public IEnumerable MammalTable { get; set; }
        public IEnumerable AmphibianTable { get; set; }
    }
}
