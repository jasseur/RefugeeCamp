using RefugeeCamp.Domaine.Entity;
using RefugeeCamp.Service.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Service.ServiceSpecifique.Interfaces
{
  public  interface IAppointmentService : IService<Appointment>
    {
        List<Appointment> getDoctorAppointments(Doctor doc);
        List<Appointment> getDoctorAppointmentsById(int docId);

        List<Appointment> getPatientAppointments(Patient patient);
        List<Appointment> getPatientAppointmentsById(int patientId);

        List<Appointment> getPatientAppointmentsByDate(DateTime date);


    }
}
