using Sales.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models.Services
{
    public class DepartmentService
    {
        public SalesContext _context { get; set; }

        public DepartmentService(SalesContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
