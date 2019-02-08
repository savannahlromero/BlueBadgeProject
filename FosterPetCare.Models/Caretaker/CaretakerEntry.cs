using FosterPetCare.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FosterPetCare.Models.Caretaker
{
    public class CaretakerEntry
    {
        [Display(Name = "Caretaker ID")]
        public int CaretakerID { get; set; }
        [Display(Name = "Name")]
        public string CaretakerName { get; set; }
        [Display(Name = "Caretaker Type")]
        public CaretakerType CaretakerType { get; set; }
        [Display(Name ="Date Joined")]
        public DateTime DateJoinedCaretaker { get; set; }
        [Display(Name = "Animal Type")]
        public AnimalType AnimalTypeCaretaker { get; set; }
    }
}