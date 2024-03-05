using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace SockMonkeyStore.Models
{
    public class CustomerBillingProfileModel
    {
        public int ID { get; set; }
        //[ForeignKey(CustomerAccountModel]
        public int AccountID { get; set; }
        [Required]
        [MinLength(16)]
        [MaxLength(16)]
        [DataType(DataType.CreditCard)]
        public string CreditCardNumber { get; set; }
        [Required]
        [MaxLength(4)]
        public string CCV { get; set; }
        public DateTime ExpirationDate { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(200)]
        public string AddressLine1 { get; set; }
        [MaxLength(200)]
        public string AddressLine2 { get; set;}
        [Required]
        [MaxLength(100)]
        public string City { get; set; }
        [Required]
        [MaxLength(2)]
        public string State { get; set; }
        [Required]
        [MaxLength(10)]
        public string Zip {  get; set; }
        //Default??
    }
}