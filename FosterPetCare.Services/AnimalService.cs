using FosterPetCare.Data;
using FosterPetCare.Models.Animal;
using FosterPetCare.WebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Services
{
    public class AnimalService
    {

        public bool CreateAnimal(AnimalCreate model)
        {
            var entity = new Animal()
            {
                AnimalName = model.AnimalName,
                AnimalType = model.AnimalType,
                DateJoinedAnimal = model.DateJoinedAnimal,
                FosterBoolAnimal = model.FosterBoolAnimal,
                AdoptedBoolAnimal = model.AdoptedBoolAnimal
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Animals.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<AnimalEntry> GetAnimals()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Animals
                    .Select(
                        new AnimalEntry
                        {

                        }

                        );
            }
        }
    }
}
