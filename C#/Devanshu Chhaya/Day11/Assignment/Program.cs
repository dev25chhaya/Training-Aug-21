using assignment.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using  (var context = new hospitalContext())
            {
               //-----Add doctor------//

                List<Doctor> doctors = new List<Doctor>()
                {
                    new Doctor(){Name="Vijay",DepartmentId=101 },
                    new Doctor(){Name="Roy", DepartmentId=102}
                };

                context.Doctors.AddRange(doctors);
                context.SaveChanges();

                var doctor = context.Doctors.First<Doctor>();
                doctor.Name = "Nilay";
                context.SaveChanges();

                var del = context.Doctors.First<Doctor>();
                context.Doctors.Remove(del);
                context.SaveChanges();

                var psummary = context.Patients

                                .Include(s => s.Treatments)
                                    .ThenInclude(c => c.Doctor)
                                .ToList();

                System.Console.WriteLine("Patients:");

                foreach (var i in psummary)
                {
                    System.Console.WriteLine("PatientName: " + i.Name);

                    foreach (var t in i.Treatments)
                    {
                        System.Console.WriteLine(t.DoctorId+" :"+t.Doctor.Name);
                        
                        
                    }
                }

                
                        

                var medicine = (from p in context.Patients
                                join d in context.DrugScheduals
                                on p.Id equals d.PatientId
                                join dr in context.Drugs
                                on d.DrugId equals dr.Id
                                where p.Name == "Akshay"
                                select new
                                {
                                    Name = p.Name,
                                    Id=dr.Id,
                                    drugname= dr.Name,
                                    Timing= dr.Timing

                                }
                                ).ToList();

                foreach (var m in medicine)
                {
                    System.Console.WriteLine("Name: " + m.Name);
                        System.Console.WriteLine("Id: " + m.Id);
                        System.Console.WriteLine("DrugName: " + m.drugname);
                        System.Console.WriteLine("Timing: " + m.Timing);
                    
                }

               

                System.Console.WriteLine("---------");

                var info = context.Doctors
                        .Include(s => s.Treatments)
                            .ThenInclude(c => c.Patient).ToList();

                foreach(var doc in info)
                {
                    System.Console.WriteLine(doc.Name);
                    foreach(var pat in doc.Treatments)
                    {
                        System.Console.WriteLine(pat.PatientId);
                        System.Console.WriteLine(pat.Patient.Name);
                    }
                }


            }
        }
    }
}
