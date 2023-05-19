using MaktabGroup4P.Models;

namespace MaktabGroup4P
{
    public class AppDB
    {
        public List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                Lname = "ali" ,
                Fname = "mohamadi" ,
                Email = "ali@gmail.com" ,
                Gender = "male" ,
                Mobail = "09365256355",
                Nationlcode=323
            },
             new Employee()
            {
                Id = 2,
                Lname = "maryam" ,
                Fname = "mahmodi" ,
                Email = "maryam@gmail.com" ,
                Gender = "female" ,
                Mobail = "09365698532",
                Nationlcode=324
            },
        };
        public List<salary> salary = new List<salary>()
        {
            new salary()
            {
                Id= 1,
                Amount =2000,
                EmployeeId= 1,
                month=1,
                OtherBenefit= "null",
                Taxt = 1,
                year=2023
            },
             new salary()
            {
                Id= 2,
                Amount =3000,
                EmployeeId= 1,
                month=2,
                OtherBenefit= "null",
                Taxt = 1,
                year=2023
            },
              new salary()
            {
                Id= 3,
                Amount =3000,
                EmployeeId= 1,
                month=3,
                OtherBenefit= "null",
                Taxt = 1,
                year=2023
            },
                 new salary()
            {
                Id= 4,
                Amount =3000,
                EmployeeId= 2,
                month=3,
                OtherBenefit= "null",
                Taxt = 1,
                year=2023
            },
                    new salary()
            {
                Id= 5,
                Amount =3000,
                EmployeeId= 2,
                month=3,
                OtherBenefit= "null",
                Taxt = 1,
                year=2023
            },
        };
    }
}
