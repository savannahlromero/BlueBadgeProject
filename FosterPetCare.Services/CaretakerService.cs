using FosterPetCare.Contracts;
using FosterPetCare.Data;
using FosterPetCare.Models.Caretaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Services
{
    public class CaretakerService: ICaretakerService
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
        public CaretakerDetail GetCaretakerByID(int caretakerID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Caretakers
                    .Single(c => c.CaretakerID == caretakerID);
                return
                    new CaretakerDetail
                    {
                        CaretakerID = entity.CaretakerID,
                        CaretakerName = entity.CaretakerName,
                        CaretakerType = entity.CaretakerType,
                        DateJoinedCaretaker = entity.DateJoinedCaretaker,
                        AnimalTypeCaretaker = entity.AnimalTypeCaretaker
                    };
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

                entity.CaretakerID = model.CaretakerID;
                entity.CaretakerName = model.CaretakerName;
                entity.CaretakerType = model.CaretakerType;
                entity.DateJoinedCaretaker = model.DateJoinedCaretaker;
                entity.AnimalTypeCaretaker = model.AnimalTypeCaretaker;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCaretaker(int caretakerID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Caretakers
                    .Single(c => c.CaretakerID == caretakerID);

                ctx.Caretakers.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
