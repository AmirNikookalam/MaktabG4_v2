using MaktabGroup4P.Services;

namespace MaktabGroup4P
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeServicecs employee = new EmployeeServicecs();
            SalaryService salary = new SalaryService();
            int personID = 0;
            int year =0 ;
            int month = 0;
            string? solutionFolderPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName;
            string path = Path.Combine(solutionFolderPath, "TotalSalary.txt");

            StreamWriter sw = new StreamWriter(path);

            Console.Write("Please give your ID: \n- ");
            personID =Convert.ToInt32 (Console.ReadLine());

            Console.Write("Please give your Year: \n- ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please give your Month: \n- ");
            month = Convert.ToInt32(Console.ReadLine());


            foreach (var item in salary.PaySlipByIdForOneMonth(personID,month,year))
            {
                Console.WriteLine($"Id Number is {item.Id} and the name is {item.Name}, The tax is {item.Tax} and amount of income is {item.Amount} and otherBenefits are {item.OtherBenefit}. ");
            }

            sw.WriteLine(salary.GetTotalSalaryById(personID));
            sw.Close();
        }
    }
}