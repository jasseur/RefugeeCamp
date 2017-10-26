using RefugeeCamp.Domaine.Entity;
using RefugeeCamp.Service.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Service.ServiceSpecifique.Interfaces.EducationInterfaces
{
   public interface ICourseService : IService<Course>
    {
         IEnumerable<Level> GetAllLevel();
    }
}
