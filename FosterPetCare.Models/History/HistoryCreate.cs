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
        public int AnimalID { get; set; }
        [Required]
        public int CaretakerID { get; set; }
        [Required]
        public string AnimalName { get; set; }
        [Required]
        public string CaretakerName { get; set; }
        [Required]
        public HistoryCareType HistoryCareType { get; set; }
        [Required]
        public DateTime DateOfCareStart { get; set; }
    }
}
