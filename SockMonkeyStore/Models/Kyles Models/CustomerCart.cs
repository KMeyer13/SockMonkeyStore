using System.Collections.Generic;

namespace SockMonkeyStore.Models
{
    public partial class CustomerCart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerCart()
        {
            this.CustomerCartItems = new HashSet<CustomerCartItem>();
        }

        public int ID { get; set; }
        public int AccountID { get; set; }

        public virtual Account Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerCartItem> CustomerCartItems { get; set; }
    }
}