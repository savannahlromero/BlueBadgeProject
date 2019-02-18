using FosterPetCare.Models.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Contracts
{
    public interface IAnimalService
    {
        bool CreateAnimal(AnimalCreate model);
        IEnumerable<AnimalEntry> GetAnimals();
        AnimalDetail GetAnimalByID(int animalID);
        bool UpdateAnimal(AnimalEdit model);
        bool DeleteAnimal(int animalID);
    }
}
