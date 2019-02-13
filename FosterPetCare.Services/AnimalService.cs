using FosterPetCare.Data;
using FosterPetCare.Models.Animal;
using FosterPetCare.Models;
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
                        a =>
                        new AnimalEntry
                        {
                            AnimalID = a.AnimalID,
                            AnimalName = a.AnimalName,
                            AnimalType = a.AnimalType,
                            DateJoinedAnimal = a.DateJoinedAnimal,
                            FosterBoolAnimal = a.FosterBoolAnimal,
                            AdoptedBoolAnimal = a.AdoptedBoolAnimal
                        }
                        );
                return query.ToArray();
            }
        }
        public AnimalDetail GetAnimalByID(int animalID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Animals
                    .Single(a => a.AnimalID == animalID);
                return
                    new AnimalDetail
                    {
                        AnimalID = entity.AnimalID,
                        AnimalName = entity.AnimalName,
                        AnimalType = entity.AnimalType,
                        DateJoinedAnimal = entity.DateJoinedAnimal,
                        FosterBoolAnimal = entity.FosterBoolAnimal,
                        AdoptedBoolAnimal = entity.AdoptedBoolAnimal
                    };
            }
        }
        public bool UpdateAnimal(AnimalEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Animals
                    .Single(a => a.AnimalID == model.AnimalID);

                entity.AnimalID = model.AnimalID;
                entity.AnimalName = model.AnimalName;
                entity.AnimalType = model.AnimalType;
                entity.DateJoinedAnimal = model.DateJoinedAnimal;
                entity.FosterBoolAnimal = model.FosterBoolAnimal;
                entity.AdoptedBoolAnimal = model.AdoptedBoolAnimal;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteAnimal(int animalID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Animals
                    .Single(a => a.AnimalID == animalID);

                ctx.Animals.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
