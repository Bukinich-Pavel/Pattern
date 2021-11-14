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

        public List<Mammal> GetMammals()
        {
            return model.GetAllMammal();
        }

        public List<Amphibian> GetAmphibians()
        {
            return model.GetAllAmphibian();
        }

        public void AddBird(Bird bird)
        {

        }

        public void AddMammal(Mammal mammal)
        {

        }

        public void AddAmphibian(Amphibian Amphibian)
        {

        }


        public void DeleteBird(Bird bird)
        {

        }

        public void DeleteMammal(Mammal mammal)
        {

        }

        public void DeleteAmphibian(object amphibian)
        {
            try
            {
                Amphibian temp = amphibian as Amphibian;
                if (temp == null) return;
                model.DeleteAmphibian(temp);
            }
            catch
            {
                return;
            }
        }

    }
}
