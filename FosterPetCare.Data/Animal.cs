using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Data
{
    public enum AnimalType {Dog, Cat, Bird, Reptile}
    public class Animal
    {
        [Key]
        public int AnimalID { get; set; }
        [Required]
        public string AnimalName { get; set; }
        [Required]
        public AnimalType AnimalType { get; set; }
        [Required]
        public DateTime DateJoinedAnimal { get; set; }
        [Required]
        public bool FosterBoolAnimal { get; set; }
        [Required]
        public bool AdoptedBoolAnimal { get; set; }
    }
}
