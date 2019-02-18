using FosterPetCare.Contracts;
using FosterPetCare.Data;
using FosterPetCare.Models.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterPetCare.Services
{
    public class HistoryService: IHistoryService
    {
        public bool CreateHistory(HistoryCreate model)
        {
            var entity = new History()
            {
                AnimalID = model.AnimalID,
                CaretakerID = model.CaretakerID,
                HistoryCareType = model.HistoryCareType,
                DateOfCareStart = model.DateOfCareStart,
            };

            using(var ctx = new ApplicationDbContext())
            {
                ctx.Histories.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<HistoryEntry> GetHistories()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Histories
                    .Select(
                        h =>
                        new HistoryEntry
                        {
                            HistoryID = h.HistoryID,
                            AnimalID = h.AnimalID,
                            CaretakerID = h.CaretakerID,
                            AnimalName = h.Animal.AnimalName,
                            CaretakerName = h.Caretaker.CaretakerName,
                            HistoryCareType = h.HistoryCareType,
                            DateOfCareStart = h.DateOfCareStart

                        });
                return query.ToArray();
            }
        }
        public HistoryDetail GetHistoryByID(int historyID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Histories
                    .Single(h => h.HistoryID == historyID);
                return
                    new HistoryDetail
                    {
                        HistoryID = entity.HistoryID,
                        AnimalID = entity.AnimalID,
                        CaretakerID = entity.CaretakerID,
                        AnimalName = entity.Animal.AnimalName,
                        CaretakerName = entity.Caretaker.CaretakerName,
                        HistoryCareType = entity.HistoryCareType,
                        DateOfCareStart = entity.DateOfCareStart
                    };
            }
        }
        public bool UpdateHistory(HistoryEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Histories
                    .Single(h => h.HistoryID == model.HistoryID);
                entity.HistoryID = model.HistoryID;
                entity.AnimalID = model.AnimalID;
                entity.CaretakerID = model.CaretakerID;
                entity.HistoryCareType = model.HistoryCareType;
                entity.DateOfCareStart = model.DateOfCareStart;

                return ctx.SaveChanges() == 1;
            };
        }
        public bool DeleteHistory(int historyID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Histories
                    .Single(h => h.HistoryID == historyID);
                ctx.Histories.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
