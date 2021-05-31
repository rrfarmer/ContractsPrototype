// Data model for a contract
using System;
using System.Collections.Generic;

namespace Prototype.Models
{
    public class contract
    {
        public int Id { get; set; }
        public string address { get; set; }
        public DateTime StartDate { get; set; }
        public int BillingPeriodId { get; set; }
        public BillingPeriod BillingPeriod { get; set; }
        public List<Unit> Units { get; set; }
    }
}