using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    /// <summary>
    /// مشکل روش قبلی این بود که فرایند رو کمی طولانی میکرد
    /// یکی دیگر راه های راحتر استفاده زا فانک است
    /// میشه از لامبادا !!!! هم استفاده کرد   
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee>()
            {
                new Employee() {Id=1, Salary=20000, Exprience=3 },
                new Employee() {Id=2, Salary=30000, Exprience=4 },
                new Employee() {Id=3, Salary=40000, Exprience=5 },
                new Employee() {Id=4, Salary=60000, Exprience=6 },
                new Employee() {Id=5, Salary=40000, Exprience=5 },
                new Employee() {Id=6, Salary=20000, Exprience=2 },
            };

            Employee ee = new Employee();
            //ee.PromotedList(emps, jamshid);
            ee.PromotedList(emps, emp => emp.Exprience > 3 );
            Console.ReadLine();
        }
        public static bool jamshid(Employee e)
        {
            if (e.Exprience > 3)
            {
                return true;
            }
            return false;
        }
    }    
    public class Employee
    {
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public int Exprience { get; set; }

        public void PromotedList(List<Employee> employes, Func<Employee, bool> algorithm)
        {
            foreach (var item in employes)
            {
                if (algorithm(item))
                {
                    Console.WriteLine($"Id: {item.Id} with {item.Salary}");
                }
            }
        }
    }    
}
