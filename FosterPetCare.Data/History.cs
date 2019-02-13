using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Data
{
    public enum HistoryCareType {Foster, Volunteer}
    public class History
    {
        [Key]
        public int HistoryID { get; set; }

        public int AnimalID { get; set; }
        public int CaretakerID { get; set; }

        public HistoryCareType HistoryCareType { get; set; }
        public DateTime DateOfCareStart { get; set; }

        public virtual Animal Animal { get; set; }
        public virtual Caretaker Caretaker { get; set; }
    }
}
