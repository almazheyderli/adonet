using Business.Services.Abstracts;
using Core.Models;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concretes
{
    public class EmployeeService : IEmployeeService
    {
        AppDbContext dbContext;
        public EmployeeService()
        {
            dbContext = new AppDbContext();
        }
        public void Create(Employee employee)
        {

            string createcommand = $"insert into Employee values('{employee.Name},{employee.Salary}')";
            int result = dbContext.NonQuery(createcommand);

        }
    }
}
