// DTO for a creating a new contract
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Prototype.Models;

namespace Prototype.Dtos
{
    public class ContractCreateDto
    {
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public string Address { get; set; } // Could possible encapsulate this in an Address Object

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Zip { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public int BillingPeriodId { get; set; }
        public BillingPeriod BillingPeriod { get; set; } // Dropdown static list

        [Required]
        public bool isActive { get; set; }

        [Required]
        public int OtherWarrantyId { get; set; }


        public OtherWarranty OtherWarranty { get; set; } // Dropdown static list

        public IList<Unit> Units { get; set; }

        public IList<ServiceVisit> ServiceVisits { get; set; }
    }
}