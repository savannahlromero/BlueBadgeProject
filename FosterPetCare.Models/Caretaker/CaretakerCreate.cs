using FosterPetCare.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Models.Caretaker
{
    public class CaretakerCreate
    {
        [Required]
        [Display(Name = "Name")]
        public string CaretakerName { get; set; }
        [Required]
        [Display(Name = "Caretaker Type")]
        public CaretakerType CaretakerType { get; set; }
        [Required]
        [Display(Name = "Date Joined")]
        public DateTime DateJoinedCaretaker { get; set; }
        [Required]
        [Display(Name = "Animal Type")]
        public AnimalType AnimalTypeCaretaker { get; set; }
    }
}
