using System;
using System.ComponentModel.DataAnnotations;

namespace SockMonkeyStore.Models
{
    public class OrdersInvoiceModel
    {
        public int ID { get; set; }
        public int AccountID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime FulfilledDate { get; set; }
        public float TotalPrice { get; set; }
        public string ShippingFirstName { get; set; }
        public string ShippingLastName { get; set; }
        public string ShippingAddressLine1 { get; set; }
        public string ShippingAddressLine2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZip { get; set; }
        public string CreditCardNumber { get; set; }        
        public string CCV { get; set; }
        public DateTime ExpirationDate { get; set; }        
        public string BillingFirstName { get; set; }        
        public string BillingLastName { get; set; }        
        public string BillingAddressLine1 { get; set; }        
        public string BillingAddressLine2 { get; set; }        
        public string BillingCity { get; set; }        
        public string BillingState { get; set; }        
        public string BillingZip { get; set; }
    }
}