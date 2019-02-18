using FosterPetCare.Models.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Contracts
{
    public interface IHistoryService
    {
        bool CreateHistory(HistoryCreate model);
        IEnumerable<HistoryEntry> GetHistories();
        HistoryDetail GetHistoryByID(int historyID);
        bool UpdateHistory(HistoryEdit model);
        bool DeleteHistory(int historyID);
    }
}
