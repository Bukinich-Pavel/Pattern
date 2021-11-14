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


        public void DeleteBird(object bird)
        {
            try
            {
                Bird temp = bird as Bird;
                if (temp == null) return;
                model.DeleteBird(temp);
            }
            catch
            {
                return;
            }
        }

        public void DeleteMammal(object mammal)
        {
            try
            {
                Mammal temp = mammal as Mammal;
                if (temp == null) return;
                model.DeleteMammal(temp);
            }
            catch
            {
                return;
            }
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


        public void UpdateBird(object bird, string newName)
        {
            try
            {
                Bird temp = bird as Bird;
                if (temp == null) return;
                temp.KindAnimal = newName;
                model.UpdateBird(temp);
            }
            catch
            {
                return;
            }

        }

        public void UpdateMammal(object mammal, string newName)
        {
            try
            {
                Mammal temp = mammal as Mammal;
                if (temp == null) return;
                temp.KindAnimal = newName;
                model.UpdateMammal(temp);
            }
            catch
            {
                return;
            }

        }

        public void UpdateAmphibion(object amphibian, string newName)
        {
            try
            {
                Amphibian temp = amphibian as Amphibian;
                if (temp == null) return;
                temp.KindAnimal = newName;
                model.UpdateAmphibian(temp);
            }
            catch
            {
                return;
            }

        }

    }
}
