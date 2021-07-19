using Proyecto_Factura_V2.Context;
using Proyecto_Factura_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V2.Services
{
    public interface IBranchService
    {
        void AddBranch(Branch branch);

        Branch GetBranch(int BranchId);
        List<Branch> GetBranches();

        void DeleteBranch(Branch branch);
        void DeleteBranch(int BranchId);

        Branch UpdateBranch(Branch branch);
    }
}
