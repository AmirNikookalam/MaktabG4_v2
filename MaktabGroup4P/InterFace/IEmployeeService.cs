using MaktabGroup4P.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGroup4P.InterFace
{
    public interface IEmployeeService
    {
        List<EmployeeNameViewModel> GetEmployeeName();
        List<EmployeeNameViewModel> GetMenEmpName();
    }
}
