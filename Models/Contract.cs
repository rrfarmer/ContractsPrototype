// Data model for a contract
using System;
using System.Collections.Generic;

namespace Prototype.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Address { get; set; } // Could possible encapsulate this in an Address Object
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public DateTime StartDate { get; set; }
        public int BillingPeriodId { get; set; }
        public BillingPeriod BillingPeriod { get; set; } // Dropdown static list
        public bool isActive { get; set; }
        public int OtherWarrantyId { get; set; }
        public OtherWarranty OtherWarranty { get; set; } // Dropdown static list
        public IList<Unit> Units { get; set; }
        public IList<ServiceVisit> ServiceVisits { get; set; }
    }
}