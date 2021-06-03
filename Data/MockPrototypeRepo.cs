// Mock implementation for testing

using System;
using System.Collections.Generic;
using Prototype.Models;

namespace Prototype.Data
{
    public class MockPrototypeRepo : IPrototypeRepo
    {
        public IEnumerable<Customer> GetAllCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = 0,
                    ContractId = 0,
                    Contract = new Contract
                    {
                        Id = 0,
                        CustomerId = 0,
                        Address = "123 North Left Ave",
                        City = "Altgard",
                        State = "IO",
                        Zip = 12345,
                        StartDate = new DateTime(2021, 1, 1),
                        BillingPeriodId = 0,
                        BillingPeriod = new BillingPeriod
                        {
                            Id = 0,
                            Name = "Monthly"
                        },
                        isActive = true,
                        NumberOfUnits = 1,
                        OtherWarrantyId = 0,
                        OtherWarranty = new OtherWarranty
                        {
                            Id = 0,
                            Name = "No Third Party"
                        }
                    },
                    FirstName = "Ryan",
                    LastName = "Farmer",
                    Phone = "555-555-5555",
                    Email = "john@dough.com",
                    Notes = "Some Notes here..."},
                new Customer
                {
                    Id = 0,
                    ContractId = 0,
                    Contract = new Contract
                    {
                        Id = 0,
                        CustomerId = 0,
                        Address = "123 North Left Ave",
                        City = "Altgard",
                        State = "IO",
                        Zip = 12345,
                        StartDate = new DateTime(2021, 1, 1),
                        BillingPeriodId = 0,
                        BillingPeriod = new BillingPeriod
                        {
                            Id = 0,
                            Name = "Monthly"
                        },
                        isActive = true,
                        NumberOfUnits = 1,
                        OtherWarrantyId = 0,
                        OtherWarranty = new OtherWarranty
                        {
                            Id = 0,
                            Name = "No Third Party"
                        }
                    },
                    FirstName = "Ryan",
                    LastName = "Farmer",
                    Phone = "555-555-5555",
                    Email = "john@dough.com",
                    Notes = "Some Notes here..."},
                new Customer
                {
                    Id = 0,
                    ContractId = 0,
                    Contract = new Contract
                    {
                        Id = 0,
                        CustomerId = 0,
                        Address = "123 North Left Ave",
                        City = "Altgard",
                        State = "IO",
                        Zip = 12345,
                        StartDate = new DateTime(2021, 1, 1),
                        BillingPeriodId = 0,
                        BillingPeriod = new BillingPeriod
                        {
                            Id = 0,
                            Name = "Monthly"
                        },
                        isActive = true,
                        NumberOfUnits = 1,
                        OtherWarrantyId = 0,
                        OtherWarranty = new OtherWarranty
                        {
                            Id = 0,
                            Name = "No Third Party"
                        }
                    },
                    FirstName = "Ryan",
                    LastName = "Farmer",
                    Phone = "555-555-5555",
                    Email = "john@dough.com",
                    Notes = "Some Notes here..."}
            };

            return customers;
        }

        public Customer GetCustomerById(int id)
        {
            return new Customer
            {
                Id = 0,
                ContractId = 0,
                Contract = new Contract
                {
                    Id = 0,
                    CustomerId = 0,
                    Address = "123 North Left Ave",
                    City = "Altgard",
                    State = "IO",
                    Zip = 12345,
                    StartDate = new DateTime(2021, 1, 1),
                    BillingPeriodId = 0,
                    BillingPeriod = new BillingPeriod
                    {
                        Id = 0,
                        Name = "Monthly"
                    },
                    isActive = true,
                    NumberOfUnits = 1,
                    OtherWarrantyId = 0,
                    OtherWarranty = new OtherWarranty
                    {
                        Id = 0,
                        Name = "No Third Party"
                    }
                },
                FirstName = "Ryan",
                LastName = "Farmer",
                Phone = "555-555-5555",
                Email = "john@dough.com",
                Notes = "Some Notes here..."
            };
        }
    }
}