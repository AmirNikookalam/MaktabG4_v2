using MaktabGroup4P.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGroup4P.InterFace
{
    public interface ISalaryService
    {
        decimal GetTotalSalaryById(int id);
        decimal GetSumTotalTaxPaid();
        List<PaySlip> PaySlipByIdForOneMonth(int id, int month, int year);
    }
    
}
