using ProjetoTreinoAspNet.Data;
using ProjetoTreinoAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTreinoAspNet.Services
{
    public class DepartmentService
    {
        private readonly ProjetoTreinoAspNetContext _context;

        public DepartmentService(ProjetoTreinoAspNetContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
