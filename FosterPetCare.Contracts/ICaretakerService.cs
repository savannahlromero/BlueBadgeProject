using FosterPetCare.Models.Caretaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Contracts
{
    public interface ICaretakerService
    {
        bool CreateCaretaker(CaretakerCreate model);
        IEnumerable<CaretakerEntry> GetCaretakers();
        CaretakerDetail GetCaretakerByID(int caretakerID);
        bool UpdateCaretaker(CaretakerEdit model);
        bool DeleteCaretaker(int caretakerID);

    }
}
