using Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Presenter
    {
        ModelVP model;
        IView view;

        public Presenter(IView view, ApplicationContext db)
        {
            this.view = view;
            model = new ModelVP(db);
        }

        public List<Bird> GetBirds()
        {
            return model.GetAllBird();
        }
    }
}
