using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Data
{
    public enum CaretakerType { Foster, Volunteer, Salary}
    public class Caretaker
    {
        [Key]
        public int CaretakerID { get; set; }
        [Required]
        public string CaretakerName { get; set; }
        [Required]
        public CaretakerType CaretakerType { get; set; }
        [Required]
        public DateTime DateJoinedCaretaker { get; set; }
        [Required]
        public AnimalType AnimalTypeCaretaker { get; set; }

    }
}
