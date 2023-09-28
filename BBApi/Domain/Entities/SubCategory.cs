using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDomain.Entities
{
    [Table("SubCategory")]
    public class SubCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Column("Name")]
        [Required]
        public string Name { get; set; }
        [Column("Thumbnail")]
        public string Thumbnail { get; set; }
        [Column("Title")]
        public string Title { get; set; }
        [Column("PrettyUrl")]
        public string PrettyUrl { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("Active")]
        [Required]
        public bool Active { get; set; }
        [Column("Static")]
        [Required]
        public bool Static { get; set; }
        
        [Column("IdCategory")]
        [ForeignKey(nameof(Category))]
        [Required]
        public int IdCategory { get; set; }

        public virtual Category Category { get; set; }
        public virtual List<InteriorCategory> InteriorCategories { get; set; }
    }
}
