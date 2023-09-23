using Microsoft.EntityFrameworkCore;

namespace MvcEfApp.Models
{
    public class RepositoryPatient
    {
        public static List<Patient> GetPatients()
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var list = ctx.Patients.ToList();
            return list;
        }
        public static Patient GetPatientById(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var Patient = ctx.Patients.Find(id);
            return Patient;
        }
        public static void AddNewPatient(Patient patients)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Patients.Add(patients);
            ctx.SaveChanges();
        }
        public static void ModifyPatient(Patient patients)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(patients).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemovePatient(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            Patient patient = ctx.Patients.Find(id);
            ctx.Patients.Remove(patient);
            ctx.SaveChanges();
        }
    }
}

