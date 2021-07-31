using ProjetoTreinoAspNet.Data;
using ProjetoTreinoAspNet.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoTreinoAspNet.Services
{
    public class DepartmentService
    {
        private readonly ProjetoTreinoAspNetContext _context;

        public DepartmentService(ProjetoTreinoAspNetContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}