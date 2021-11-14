using Microsoft.EntityFrameworkCore;
using Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class ModelVP
    {
        ApplicationContext db;

        public ModelVP(ApplicationContext db)
        {
            this.db = db;
        }

        public List<Bird> GetAllBird()
        {
            var temp = db.Birds.ToList();
            return temp;
        }

        public List<Mammal> GetAllMammal()
        {
            var temp = db.Mammals.ToList();
            return temp;
        }

        public List<Amphibian> GetAllAmphibian()
        {
            var temp = db.Amphibians.ToList();
            return temp;
        }

        public void AddBird(Bird bird)
        {
            db.Birds.Add(bird);
            db.SaveChanges();
        }

        public void AddMammal(Mammal mammal)
        {
            db.Mammals.Add(mammal);
            db.SaveChanges();
        }

        public void AddAmphibian(Amphibian amphibian)
        {
            db.Amphibians.Add(amphibian);
            db.SaveChanges();
        }


        public void DeleteBird(Bird bird)
        {
            db.Birds.Remove(bird);
            db.SaveChanges();
        }

        public void DeleteMammal(Mammal mammal)
        {
            db.Mammals.Remove(mammal);
            db.SaveChanges();
        }

        public void DeleteAmphibian(Amphibian amphibian)
        {
            db.Amphibians.Remove(amphibian);
            db.SaveChanges();
        }


        public void UpdateBird(Bird bird)
        {
            if (bird == null) return;

            db.Birds.Update(bird);
            db.SaveChanges();
        }

        public void UpdateMammal(Mammal mammal)
        {
            if (mammal == null) return;

            db.Mammals.Update(mammal);
            db.SaveChanges();
        }

        public void UpdateAmphibian(Amphibian amphibian)
        {
            if (amphibian == null) return;

            db.Amphibians.Update(amphibian);
            db.SaveChanges();
        }
    }
}
