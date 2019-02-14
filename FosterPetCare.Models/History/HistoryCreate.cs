using FosterPetCare.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Models.History
{
    public class HistoryCreate
    {
        [Required]
        [Display(Name = "Animal ID")]
        public int AnimalID { get; set; }

        [Required]
        [Display(Name = "Caretaker ID")]
        public int CaretakerID { get; set; }

        [Display(Name = "Name of Animal")]
        public string AnimalName { get; set; }

        [Display(Name = "Name of Caretaker")]
        public string CaretakerName { get; set; }

        [Required]
        [Display(Name = "Foster or Volunteer Care?")]
        public HistoryCareType HistoryCareType { get; set; }

        [Required]
        [Display(Name = "Initial Date of Care")]
        public DateTime DateOfCareStart { get; set; }
    }
}
