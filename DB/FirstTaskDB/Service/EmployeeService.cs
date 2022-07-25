using FirstTaskDB.Data;
using FirstTaskDB.Models;
using System.Collections.Generic;
using System.Linq;

namespace FirstTaskDB.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _db;

        public EmployeeService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<Employee> GetAll()
        {
            var employees = _db.Employees.ToList();
            return employees;
        }
        public Employee Get(int Id)
        {
            var employees = _db.Employees.Find(Id);
            return employees;
        }
        public void Delete (int Id)
        {
            var employees=_db.Employees.Find(Id);
            _db.Employees.Remove(employees);
            _db.SaveChanges();
        }
    }
}
