using BBDomain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBApplication.DTOs
{
    public class SubCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public string Title { get; set; }
        public string PrettyUrl { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool Static { get; set; }
        public int IdCategory { get; set; }
        public List<InteriorCategoryDTO>? InteriorCategories { get; set; }
    }
}
