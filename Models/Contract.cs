// Data model for a contract
using System;
using System.Collections.Generic;

namespace Prototype.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public DateTime StartDate { get; set; }
        public int BillingPeriodId { get; set; }
        public BillingPeriod BillingPeriod { get; set; }
        public bool Active { get; set; }
        public bool IsPaidCurrent { get; set; }
        public int NumberOfUnits { get; set; }

        // Add this in later version
        //public List<Unit> Units { get; set; }
        //public List<DateTime> ServiceVisits { get; set; }
    }
}