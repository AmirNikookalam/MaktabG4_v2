using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MaktabGroup4P.Models
{
    public class salary
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int Taxt { get; set; }
        public string OtherBenefit { get; set; }
        public int  EmployeeId { get; set; }
        public int year { get; set; }
        public int month { get; set; }
    }
}
