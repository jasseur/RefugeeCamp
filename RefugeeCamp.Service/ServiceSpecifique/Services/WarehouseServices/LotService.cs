using RefugeeCamp.Data.Infrastructure;
using RefugeeCamp.Domaine.Entity;
using RefugeeCamp.Service.ServicePattern;
using RefugeeCamp.Service.ServiceSpecifique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Service.ServiceSpecifique.Services
{
    public class LotService : Service<Lot>, ILotService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork uof = new UnitOfWork(dbf);

        public LotService() : base(uof)
        {

        }

        public List<Lot> getLotExpiredDate()
        {
            return GetAll().Where(l => l.ExpiryDate.Year <= DateTime.Now.Year && l.ExpiryDate.Month <= DateTime.Now.Month && l.ExpiryDate.Day <= DateTime.Now.Day).ToList();
        }
    }
}
