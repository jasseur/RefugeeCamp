using RefugeeCamp.Domaine.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Service.ServiceSpecifique.Interfaces.EducationInterfaces
{
    interface IClassroomService
    {
        IEnumerable<Teacher> GetAllTeacher();
        IEnumerable<Level> GetAllLevel();
    }
}
