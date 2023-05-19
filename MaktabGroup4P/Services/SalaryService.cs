using MaktabGroup4P;
using MaktabGroup4P.InterFace;
using MaktabGroup4P.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGroup4P.Services
{
    public class SalaryService : ISalaryService
    {
    AppDB dataBase = new AppDB();
        public decimal GetSumTotalTaxPaid()
        {
            var taxSum = (from db in dataBase.salary select db.Tax).Sum();
            return taxSum;
        }

        public decimal GetTotalSalaryById(int id)
        {
            var salarySum = (from db in dataBase.salary 
                         where db.EmployeeId == id
                         select db.Amount + db.OtherBenefit - db.Tax).Sum();
            return salarySum;
        }

        public List<PaySlip> PaySlipByIdForOneMonth(int id, int month, int year)
        {
            var slip = (from db in dataBase.salary
                        join em in dataBase.employees on db.EmployeeId equals em.Id

                        where db.month == month && db.year == year && db.EmployeeId == id
                        select new PaySlip() {Id = em.Id, Name = em.Lname, Amount = db.Amount, Tax = db.Tax, OtherBenefit = db.OtherBenefit}).ToList();
            return slip;
        }
    }
}
