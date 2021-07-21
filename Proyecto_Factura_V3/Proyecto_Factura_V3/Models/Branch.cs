using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Models
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }

        [Required(ErrorMessage = "Enter the name of the branch")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
