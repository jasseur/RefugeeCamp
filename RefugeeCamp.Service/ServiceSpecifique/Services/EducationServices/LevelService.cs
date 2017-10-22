using RefugeeCamp.Data.Infrastructure;
using RefugeeCamp.Domaine.Entity;
using RefugeeCamp.Service.ServicePattern;
using RefugeeCamp.Service.ServiceSpecifique.Interfaces.EducationInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Service.ServiceSpecifique.Services.EducationServices
{
  public  class LevelService : Service<Level>, ILevelService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork uof = new UnitOfWork(dbf);

        public LevelService() : base(uof)
        {

        }


    }
}
