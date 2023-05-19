using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGroup4P.ViewModel
{
    public class PaySlip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobail { get; set; }
        public string National { get; set; }
        public string Amount { get; set; }
        public string Tax { get; set; }
        public string OtherBenefit { get; set; }
    }
}
