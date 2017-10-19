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
  public class AppointmentService : Service<Appointment>,IAppointmentService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork uof = new UnitOfWork(dbf);

        public AppointmentService() : base(uof)
        {

        }

        public List<Appointment> getDoctorAppointments(Doctor doc)
        {
            return this.GetMany(app =>  
            app.DoctorId.Equals(doc.Id)).ToList<Appointment>();
        }

        public List<Appointment> getDoctorAppointmentsById(int docId)
        {
            return this.GetMany(app =>
            app.DoctorId.Equals(docId)).ToList<Appointment>();
        }

        public List<Appointment> getPatientAppointments(Patient patient)
        {
            return this.GetMany(app =>
              app.Patient.Equals(patient.Id)).ToList<Appointment>();

        }

        public List<Appointment> getPatientAppointmentsById(int patientId)
        {
            return this.GetMany(app =>
            app.DoctorId.Equals(patientId)).ToList<Appointment>();
        }

        public List<Appointment> getPatientAppointmentsByDate(DateTime date)
        {
            return this.GetMany(app =>
            app.DateAppointment.Equals(date)).ToList<Appointment>();
        }


    }
}
