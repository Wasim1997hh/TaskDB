using FirstTaskDB.Models;
using System.Collections.Generic;

namespace FirstTaskDB.Service
{
    public interface IEmployeeService
    {
        Employee Get(int Id);
        List<Employee> GetAll();
        void Delete(int Id);
    }
}