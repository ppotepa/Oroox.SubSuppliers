using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using Oroox.SubSuppliers.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Domain
{
    public class Program
    {
        public static async Task Main()
        {
            SubSuppliersContext ctx = new SubSuppliersContext(false);
            //ctx.Jobs.Add
            //(
            //    new Job
            //    {
            //        CustomerId = ctx.Customers.First().Id,
            //        SharedJobs = new List<SharedJob>()
            //        {
            //            new SharedJob
            //            {
            //                Comments = new List<Comment>
            //                {
            //                    new Comment
            //                    {
            //                        Text = "Some text"
            //                    }
            //                }
            //            }
            //        }
            //    }
            //);
        }

        private static Customer NewCustomer(SubSuppliersContext ctx, int index)
        {
            Customer newCustomer = new Customer
            {
                CompanySizeType = ctx.Enumerations.CompanySizeTypes[CompanySizeTypeEnum.LessThan10],
                Addresses = new[]
                {
                    new Address
                    {
                        AddressType = ctx.Enumerations.AddressTypes[AddressTypeEnum.Shipping],
                        CountryCodeType = ctx.Enumerations.CountryCodeTypes[CountryCodeTypeEnum.AD],
                        PhoneNumber = "123 123 123",
                        Street = "Jakas ulica 20",
                    }
                },
                Machines = new List<Machine>
                {
                    new MillingMachine
                    {
                       MachineNumber = "T2",
                        Name = "MillingMachine",
                        CNCMachineAxesType = ctx.Enumerations.CNCMachineAxesTypes[CNCMachineAxesTypeEnum.THREE_AXIS],
                        XMax  = 10f,
                        YMax = 20f,
                        YMin = 30f,
                        XMin = 40f,
                    },
                     new MillingMachine
                    {
                       MachineNumber = "T1",
                        Name = "TurningMachine",
                        CNCMachineAxesType = ctx.Enumerations.CNCMachineAxesTypes[CNCMachineAxesTypeEnum.THREE_AXIS],
                        XMax  = 4.0f,
                        YMax = 30f,
                        YMin = 40f,
                        XMin = 20f,
                        ZMax = 10f,
                        ZMin = 100f
                    },
                },
                EmailAddress = $"robert.shmidt{index}@someCompany.com",
                OtherTechnologies = new[]
                {
                    ctx.Enumerations.OtherTechnologyTypes[OtherTechnologyTypeEnum.Annealing],
                    ctx.Enumerations.OtherTechnologyTypes[OtherTechnologyTypeEnum.Engravings],
                },
                CompanyName = "Shmidt and Family",
                RegistrationNumber = "00/01/2000",
                VATNumber = "000-000-000-000-000",
                Website = "http://shmidt-ompany.de",
                CustomerAdditionalInfo = new CustomerAdditionalInfo()
                {
                    AverageAndFastestLeadTimeMilling = 5,
                    AverageAndFastestLeadTimeTurning = 5,
                    AverageMinimalSurfaceQualitiesMilling = 5,
                    AverageMinimalSurfaceQualitiesTurning = 5,
                    AverageWorkingHoursPerWeek = 4,
                    CanUseStepFiles = true,
                    SpecialCharacteristics = "",
                    SpecialTolerances = "Black and white",
                    WorkingShiftsPerDay = 4,
                },
                Certifications = new[]
                {
                    ctx.Enumerations.Certifications[CertificationTypeEnum.EN9100],
                    ctx.Enumerations.Certifications[CertificationTypeEnum.ISO14001],
                }
            };

            newCustomer.AddMachine(new TurningMachine
            {
                CNCMachineAxesType = ctx.Enumerations.CNCMachineAxesTypes[CNCMachineAxesTypeEnum.THREE_AXIS],
                MachineNumber = "200",
                Name = "Test",
                XMax = 595959595,
            });

            newCustomer.AddMachine(new MillingMachine
            {
                CNCMachineAxesType = ctx.Enumerations.CNCMachineAxesTypes[CNCMachineAxesTypeEnum.THREE_AXIS],
                MachineNumber = "2001",
                Name = "Tes2t",
                XMax = 5959595,
            });
            return newCustomer;
        }
    }
}
