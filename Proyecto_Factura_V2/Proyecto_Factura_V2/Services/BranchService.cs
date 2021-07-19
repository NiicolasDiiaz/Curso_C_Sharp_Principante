using Microsoft.EntityFrameworkCore;
using Proyecto_Factura_V2.Context;
using Proyecto_Factura_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V2.Services
{
    public class BranchService : IBranchService
    {
        private readonly IDDBBContext _contextoDB;

        public BranchService(IDDBBContext contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public void AddBranch(Branch branch)
        {
            _contextoDB.Branches.Add(branch);
            _contextoDB.SaveChanges();
        }

        public Branch GetBranch(int BranchId)
        {
            return _contextoDB.Branches.Where(x => x.BranchId == BranchId).FirstOrDefault();
        }
        public List<Branch> GetBranches()
        {
            return _contextoDB.Branches.Select(x => x).ToList();
        }

        public void DeleteBranch(Branch branch)
        {
            _contextoDB.Branches.Remove(branch);
            _contextoDB.SaveChanges();
        }
        public void DeleteBranch(int BranchId)
        {
            var branch = GetBranch(BranchId);
            DeleteBranch(branch);
        }

        public Branch UpdateBranch(Branch branch)
        {
            var branchUpdated = _contextoDB.Branches.Update(branch).Entity;
            _contextoDB.SaveChanges();
            return branchUpdated;
        }
    }
}
