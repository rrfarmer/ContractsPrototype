// Data model for a contract
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        [Required]
        public string Address { get; set; } // Could possible encapsulate this in an Address Object
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public int BillingPeriodId { get; set; }
        public BillingPeriod BillingPeriod { get; set; } // Dropdown static list
        public bool isActive { get; set; }
        public int OtherWarrantyId { get; set; }
        public OtherWarranty OtherWarranty { get; set; } // Dropdown static list
        public IList<Unit> Units { get; set; }
        public IList<ServiceVisit> ServiceVisits { get; set; }
    }
}