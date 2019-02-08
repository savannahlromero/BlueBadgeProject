using FosterPetCare.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Models.Animal
{
    public class AnimalEdit
    {
        [Display(Name = "Animal ID")]
        public int AnimalID { get; set; }
        [Display(Name = "Name")]
        public string AnimalName { get; set; }
        [Display(Name = "Animal Type")]
        public AnimalType AnimalType { get; set; }
        [Display(Name = "Date Joined")]
        public DateTime DateJoinedAnimal { get; set; }
        [Display(Name = "In Foster Care?")]
        public bool FosterBoolAnimal { get; set; }
        [Display(Name = "Adopted?")]
        public bool AdoptedBoolAnimal { get; set; }
    }
}
