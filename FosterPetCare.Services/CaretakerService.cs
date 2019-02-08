using FosterPetCare.Data;
using FosterPetCare.Models.Caretaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Services
{
    public class CaretakerService
    {
        public bool CreateCaretaker(CaretakerCreate model)
        {
            var entity = new Caretaker()
            {
                CaretakerName = model.CaretakerName,
                CaretakerType = model.CaretakerType,
                DateJoinedCaretaker = model.DateJoinedCaretaker,
                AnimalTypeCaretaker = model.AnimalTypeCaretaker
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Caretakers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<CaretakerEntry> GetCaretakers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Caretakers
                    .Select(
                        c =>
                        new CaretakerEntry
                        {
                            CaretakerID = c.CaretakerID,
                            CaretakerName = c.CaretakerName,
                            CaretakerType = c.CaretakerType,
                            DateJoinedCaretaker = c.DateJoinedCaretaker,
                            AnimalTypeCaretaker = c.AnimalTypeCaretaker
                        }
                        );
                return query.ToArray();
            }
        }
        public bool UpdateCaretaker(CaretakerEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Caretakers
                    .Single(c => c.CaretakerID == model.CaretakerID);
                // FINISH ADDING STUFF HERE
            }
        }
    }
}
