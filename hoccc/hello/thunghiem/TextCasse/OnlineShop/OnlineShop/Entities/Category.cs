using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Entities
{
    [Table("Category")]
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        [Key]
        public long ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Link { get; set; }

        public bool Status { get; set; }
        [NotMapped]
        public int CountProduct { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty("Category")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
