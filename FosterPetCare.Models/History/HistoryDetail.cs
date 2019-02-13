using FosterPetCare.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Models.History
{
    public class HistoryDetail
    {
        public int HistoryID { get; set; }
        public int AnimalID { get; set; }
        public int CaretakerID { get; set; }
        public string AnimalName { get; set; }
        public string CaretakerName { get; set; }
        public HistoryCareType HistoryCareType { get; set; }
        public DateTime DateOfCareStart { get; set; }
    }
}
