// Mock implementation for testing

using System;
using System.Collections.Generic;
using Prototype.Models;

namespace Prototype.Data
{
    public class MockPrototypeRepo : IPrototypeRepo
    {
        public void CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                Id = 0,
                Contracts = new List<Contract>
                {
                    new Contract
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
                        OtherWarrantyId = 0,
                        OtherWarranty = new OtherWarranty
                        {
                            Id = 0,
                            Name = "No Third Party"
                        },
                        Units = new List<Unit>
                        {
                            new Unit{
                                Id = 0,
                                MediaFilterId = 0,
                                MediaFilter = new MediaFilter
                                {
                                    Id = 0,
                                    Size = "16x16"
                                }
                            },
                            new Unit{
                                Id = 1,
                                MediaFilterId = 0,
                                MediaFilter = new MediaFilter
                                {
                                    Id = 0,
                                    Size = "16x16"
                                }
                            }
                        },
                        ServiceVisits = new List<ServiceVisit>
                        {
                            new ServiceVisit
                            {
                                Id = 0,
                                Visit = new DateTime(2021, 1, 1)
                            },
                            new ServiceVisit
                            {
                                Id = 0,
                                Visit = new DateTime(2021, 1, 1)
                            }
                        }
                    }
                },
                FirstName = "Ryan",
                LastName = "Farmer",
                Phone = "555-555-5555",
                Email = "john@dough.com",
                Notes = "Some Notes here..."
            },
                new Customer
                {
                Id = 0,
                Contracts = new List<Contract>
                {
                    new Contract
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
                        OtherWarrantyId = 0,
                        OtherWarranty = new OtherWarranty
                        {
                            Id = 0,
                            Name = "No Third Party"
                        },
                        Units = new List<Unit>
                        {
                            new Unit{
                                Id = 0,
                                MediaFilterId = 0,
                                MediaFilter = new MediaFilter
                                {
                                    Id = 0,
                                    Size = "16x16"
                                }
                            },
                            new Unit{
                                Id = 1,
                                MediaFilterId = 0,
                                MediaFilter = new MediaFilter
                                {
                                    Id = 0,
                                    Size = "16x16"
                                }
                            }
                        },
                        ServiceVisits = new List<ServiceVisit>
                        {
                            new ServiceVisit
                            {
                                Id = 0,
                                Visit = new DateTime(2021, 1, 1)
                            },
                            new ServiceVisit
                            {
                                Id = 0,
                                Visit = new DateTime(2021, 1, 1)
                            }
                        }
                    }
                },
                FirstName = "Ryan",
                LastName = "Farmer",
                Phone = "555-555-5555",
                Email = "john@dough.com",
                Notes = "Some Notes here..."
            },
                new Customer
                {
                Id = 0,
                Contracts = new List<Contract>
                {
                    new Contract
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
                        OtherWarrantyId = 0,
                        OtherWarranty = new OtherWarranty
                        {
                            Id = 0,
                            Name = "No Third Party"
                        },
                        Units = new List<Unit>
                        {
                            new Unit{
                                Id = 0,
                                MediaFilterId = 0,
                                MediaFilter = new MediaFilter
                                {
                                    Id = 0,
                                    Size = "16x16"
                                }
                            },
                            new Unit{
                                Id = 1,
                                MediaFilterId = 0,
                                MediaFilter = new MediaFilter
                                {
                                    Id = 0,
                                    Size = "16x16"
                                }
                            }
                        },
                        ServiceVisits = new List<ServiceVisit>
                        {
                            new ServiceVisit
                            {
                                Id = 0,
                                Visit = new DateTime(2021, 1, 1)
                            },
                            new ServiceVisit
                            {
                                Id = 0,
                                Visit = new DateTime(2021, 1, 1)
                            }
                        }
                    }
                },
                FirstName = "Ryan",
                LastName = "Farmer",
                Phone = "555-555-5555",
                Email = "john@dough.com",
                Notes = "Some Notes here..."
            }
            };

            return customers;
        }

        public Customer GetCustomerById(int id)
        {
            return new Customer
            {
                Id = 0,
                Contracts = new List<Contract>
                {
                    new Contract
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
                        OtherWarrantyId = 0,
                        OtherWarranty = new OtherWarranty
                        {
                            Id = 0,
                            Name = "No Third Party"
                        },
                        Units = new List<Unit>
                        {
                            new Unit{
                                Id = 0,
                                MediaFilterId = 0,
                                MediaFilter = new MediaFilter
                                {
                                    Id = 0,
                                    Size = "16x16"
                                }
                            },
                            new Unit{
                                Id = 1,
                                MediaFilterId = 0,
                                MediaFilter = new MediaFilter
                                {
                                    Id = 0,
                                    Size = "16x16"
                                }
                            }
                        },
                        ServiceVisits = new List<ServiceVisit>
                        {
                            new ServiceVisit
                            {
                                Id = 0,
                                Visit = new DateTime(2021, 1, 1)
                            },
                            new ServiceVisit
                            {
                                Id = 0,
                                Visit = new DateTime(2021, 1, 1)
                            }
                        }
                    }
                },
                FirstName = "Ryan",
                LastName = "Farmer",
                Phone = "555-555-5555",
                Email = "john@dough.com",
                Notes = "Some Notes here..."
            };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}