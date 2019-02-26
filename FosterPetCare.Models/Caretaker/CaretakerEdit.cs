using FosterPetCare.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Models.Caretaker
{
    public class CaretakerEdit
    {
        [Display(Name = "Caretaker ID")]
        public int CaretakerID { get; set; }
        [Display(Name = "Name")]
        public string CaretakerName { get; set; }
        [Display(Name = "Caretaker Type")]
        public CaretakerType CaretakerType { get; set; }
        [Display(Name = "Date Joined")]
        public DateTime DateJoinedCaretaker { get; set; }
        [Display(Name = "Preferred Animal Type")]
        public AnimalType AnimalTypeCaretaker { get; set; }
    }
}
