using Healthcare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ToysCompany.Interfaces
{
    public interface IDoctorRepository
    {
        List<Doctor> GetDoctors();
        Doctor GetDoctor(int id);

        Doctor AddDoctor(Doctor customer);
        void DeleteDoctor(Doctor customer);
        Doctor EditDoctor(Doctor customer);

    }
}