﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SockMonkeyStore.Models
{
    public partial class OrderInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderInvoice()
        {
            this.OrderInvoiceItems = new HashSet<OrderInvoiceItem>();
        }

        public int ID { get; set; }
        public int AccountID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> FulfilledDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string ShippingFirstname { get; set; }
        public string ShippingLastName { get; set; }
        public string ShippingAddressLine1 { get; set; }
        public string ShippingAddressLine2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZip { get; set; }
        public string CreditCardNumber { get; set; }
        public string CCV { get; set; }
        public string BillingFirstname { get; set; }
        public string BillingLastName { get; set; }
        public string BillingAddressLine1 { get; set; }
        public string BillingAddressLine2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZip { get; set; }

        public virtual Account Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderInvoiceItem> OrderInvoiceItems { get; set; }
    }
}