using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoTreinoAspNet.Data;
using ProjetoTreinoAspNet.Models;

namespace ProjetoTreinoAspNet.Services
{
    public class SellerService
    {
//CRL Lindo
        private readonly ProjetoTreinoAspNetContext _context;

        public SellerService(ProjetoTreinoAspNetContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
