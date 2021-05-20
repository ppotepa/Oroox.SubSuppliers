using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Domain
{
    public class Program
    {
        public static async Task Main()
        {
            SubSuppliersContext ctx = new SubSuppliersContext(true);

            Customer newCustomer = new Customer
            {
                CompanySizeType = ctx.Enumerations.CompanyTypes[CompanySizeTypeEnum.LessThan10],
                Addresses = new[]
                {
                    new Address
                    {
                        AddressType = ctx.Enumerations.AddressTypes[AddressTypeEnum.Shipping],
                        CountryCodeType = ctx.Enumerations.CountryCodes[CountryCodeTypeEnum.AD],
                        Deleted = false,
                        PhoneNumber = "123 123 123",
                        Street = "Jakas ulica 20",
                    }
                },
                MillingMachines = new[]
                {
                    new MillingMachine
                    {
                        MachineNumber = "TYPE_1",
                        MillingMachineType = ctx.Enumerations.MillingMachines[MillingMachineTypeEnum.TYPE_1],
                        MillingMachineDimensionsType = ctx.Enumerations.MillingMachineDimensionsTypes[MillingMachineDimensionsTypeEnum.FIVE_AXIS],
                        Deleted = false,
                        MaximalMachiningDimensions = 5,
                        MinimalMachiningDimensions = 10,
                        Name = "SuperMachine2000"
                    },
                    new MillingMachine
                    {
                        MachineNumber = "TYPE_2",
                        MillingMachineType = ctx.Enumerations.MillingMachines[MillingMachineTypeEnum.TYPE_1],
                        MillingMachineDimensionsType = ctx.Enumerations.MillingMachineDimensionsTypes[MillingMachineDimensionsTypeEnum.FIVE_AXIS],
                        Deleted = false,
                        MaximalMachiningDimensions = 5,
                        MinimalMachiningDimensions = 5,
                        Name = "SuperMachine4000"
                    },
                    new MillingMachine
                    {
                        MachineNumber = "TYPE_3",
                        MillingMachineType = ctx.Enumerations.MillingMachines[MillingMachineTypeEnum.TYPE_1],
                        MillingMachineDimensionsType = ctx.Enumerations.MillingMachineDimensionsTypes[MillingMachineDimensionsTypeEnum.FIVE_AXIS],
                        Deleted = false,
                        MaximalMachiningDimensions = 1,
                        MinimalMachiningDimensions = 2,
                        Name = "SuperMachine1000"
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

            ctx.Customers.Add(newCustomer);
            ctx.SaveChanges();
        }
    }
}
