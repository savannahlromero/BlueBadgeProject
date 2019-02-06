using FosterPetCare.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Models.Animal
{
    public class AnimalCreate
    {
        [Required]
        [Display(Name = "Name")]
        public string AnimalName { get; set; }
        [Required]
        [Display(Name = "Animal Type")]
        public AnimalType AnimalType { get; set; }
        [Required]
        [Display(Name = "Date Joined")]
        public DateTime DateJoinedAnimal { get; set; }
        [Required]
        [Display(Name = "In Foster Care?")]
        public bool FosterBoolAnimal { get; set; }
        [Required]
        [Display(Name = "Adopted?")]
        public bool AdoptedBoolAnimal { get; set; }
    }
}
