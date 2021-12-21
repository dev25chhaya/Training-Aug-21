using Healthcare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToysCompany.Interfaces;

namespace Healthcare.Repository
{
    public class DoctorRepository: IDoctorRepository
    {
        
            private readonly hospitalContext _context;

            public DoctorRepository(hospitalContext context)
            {
                _context = context;
            }

            public Doctor AddDoctor(Doctor doctor)
            {
                
                _context.Doctors.Add(doctor);
                _context.SaveChanges();
                return doctor;
            }

            public void DeleteDoctor(Doctor doctor)
            {
                _context.Doctors.Remove(doctor);
                _context.SaveChanges();
            }

            public Doctor EditDoctor(Doctor doctor)
            {
                var ExistingDoctor = _context.Doctors.Find(doctor.Id);
                if (ExistingDoctor != null)
                {
                    ExistingDoctor.Name = doctor.Name;
                    _context.Doctors.Update(doctor);
                    _context.SaveChanges();
                }
                return doctor;
            }

            public Doctor GetDoctor(int id)
            {
                var doctor = _context.Doctors.Find(id);
                return doctor;
            }

            public List<Doctor> GetDoctors()
            {
                return _context.Doctors.ToList();
            }
        
    }
}
