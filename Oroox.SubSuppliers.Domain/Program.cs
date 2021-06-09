using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
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

            Customer newCustomer = new Customer
            {
                CompanySizeType = ctx.Enumerations.CompanyTypes[CompanySizeTypeEnum.LessThan10],
                Addresses = new[]
                {
                    new Address
                    {
                        AddressType = ctx.Enumerations.AddressTypes[AddressTypeEnum.Shipping],
                        CountryCodeType = ctx.Enumerations.CountryCodes[CountryCodeTypeEnum.AD],
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
                        CNCMachineAxesType = ctx.Enumerations.CNCAxesTypes[CNCMachineAxesTypeEnum.THREE_AXIS],
                        XMax  = 2,
                        YMax = 3,
                        YMin = 4,
                        XMin = 2,
                    },
                     new TurningMachine
                    {
                       MachineNumber = "T1",
                        Name = "TurningMachine",
                        CNCMachineAxesType = ctx.Enumerations.CNCAxesTypes[CNCMachineAxesTypeEnum.THREE_AXIS],
                        XMax  = 2,
                        YMax = 3,
                        YMin = 4,
                        XMin = 2,
                    },
                },
                EmailAddress = "robert.shmidt@someCompany.com",
                OtherTechnologies = new[]
                {
                    ctx.Enumerations.OtherTechnologies[OtherTechnologyTypeEnum.Annealing],
                    ctx.Enumerations.OtherTechnologies[OtherTechnologyTypeEnum.Engravings],
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
                CNCMachineAxesType = ctx.Enumerations.CNCAxesTypes[CNCMachineAxesTypeEnum.THREE_AXIS],
                MachineNumber = "200",
                Name = "Test",
                XMax = 595959595,
            }, null);

            ctx.Customers.Add(newCustomer);

            var allCustomers = await ctx.Customers.AsQueryable().ToListAsync();
            //var machines = allCustomers.FirstOrDefault(c => c.TurningMachines.Any()).TurningMachines;

            ctx.SaveChanges();
        }
    }
}
