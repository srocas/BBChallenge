using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDomain.Entities
{
    public class PostCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Column("IdCategory")]
        [ForeignKey(nameof(Category))]
        [Required]
        public int IdCategory { get; set; }

        [Column("IdPost")]
        [ForeignKey(nameof(Post))]
        [Required]
        public int IdPost { get; set; }

        [Column("IdSubCategory")]
        [ForeignKey(nameof(SubCategory))]
        public int? IdSubCategory { get; set; }

        [Column("IdInteriorCategory")]
        [ForeignKey(nameof(InteriorCategory))]
        public int? IdInteriorCategory { get; set; }
        public virtual Category Category { get; set; }
        public virtual Post Post { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual InteriorCategory InteriorCategory { get; set; }
    }
}
