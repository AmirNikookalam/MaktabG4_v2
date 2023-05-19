using MaktabGroup4P.InterFace;
using MaktabGroup4P.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGroup4P.Services
{
    public class EmployeeServicecs : IEmployeeService
    {
        AppDB dataBase = new AppDB();
        public List<EmployeeNameViewModel> GetEmployeeName()
        {
            var empNames = from db in dataBase.employees select new EmployeeNameViewModel() {Fname = db.Fname,Lname = db.Lname,Id = db.Id};
            return empNames.ToList();
        }

        public List<EmployeeNameViewModel> GetMenEmpName()
        {
            var empMenNames = from db in dataBase.employees
                              where db.Gender == "male" 
                              select new EmployeeNameViewModel() { Fname = db.Fname, Lname = db.Lname, Id = db.Id };
            return empMenNames.ToList();
        }
         
    }
}
