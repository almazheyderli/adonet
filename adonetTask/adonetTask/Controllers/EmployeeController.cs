using Business.Services.Abstracts;
using Business.Services.Concretes;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetTask.Controllers
{
    public class EmployeeController
    {
        IEmployeeService _employeeService=new EmployeeService();
        public void Add()
        {
            Console.WriteLine("Iscinin adini daxil edin");
            string name=Console.ReadLine();
            Console.WriteLine("iscinin maasini daxil edin");
            decimal salary=decimal.Parse(Console.ReadLine());

            Employee employee = new Employee();
           
            _employeeService.Create(employee);
        }
    }
}
