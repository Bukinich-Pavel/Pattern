using Pattern.Factory;
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

        public void SaveToFile()
        {
            var writerBird = new WriterLibrary.Writer<Bird>(new WriterLibrary.SaveToPDF("Птицы"), model.GetAllBird());
            writerBird.Save();
            var writerMammal = new WriterLibrary.Writer<Mammal>(new WriterLibrary.SaveToPDF("Млекопитающие"), model.GetAllMammal());
            writerMammal.Save();
            var writerAmphibian = new WriterLibrary.Writer<Amphibian>(new WriterLibrary.SaveToPDF("Земноводные"), model.GetAllAmphibian());
            writerAmphibian.Save();
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


        public void AddAnimal(string typeAnimal, string kindAnimal)
        {
            if (string.IsNullOrEmpty(typeAnimal) || string.IsNullOrEmpty(kindAnimal)) return;

            IAnimal animal = AnimalFactory.GetAnimal(typeAnimal, kindAnimal);
            if(animal is Bird)
            {
                model.AddBird(animal as Bird);
            }
            else if (animal is Mammal)
            {
                model.AddMammal(animal as Mammal);
            }
            else if (animal is Amphibian)
            {
                model.AddAmphibian(animal as Amphibian);
            }
            else
            {
                return;
            }
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
