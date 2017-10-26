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
    public class StudentService : Service<Student>, IStudentService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork uof = new UnitOfWork(dbf);

        public StudentService() : base(uof)
        {

        }

        public IEnumerable<Level> GetAllLevel()
        {
            return uof.GetRepository<Level>().GetAll();

        }
    }
}
