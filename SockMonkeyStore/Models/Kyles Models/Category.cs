using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SockMonkeyStore.Models
{
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            this.ProductCategories = new HashSet<ProductCategory>();
        }

        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string CategorySlug { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}