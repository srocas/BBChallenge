using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDomain.Entities
{
    public class PostCategoryDTO
    {
        public int Id { get; set; }
        public int IdCategory { get; set; }
        public int IdPost { get; set; }
        public int? IdSubCategory { get; set; }
        public int? IdInteriorCategory { get; set; }

        public string? Category { get; set; }
        public string? SubCategory { get; set; }
        public string? InteriorCategory { get; set; }
    }
}
