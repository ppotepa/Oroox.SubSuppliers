using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using Oroox.SubSuppliers.Domain.Extensions;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Domain
{
    public class Program
    {
        public static async Task Main()
        {
            SubSuppliersContext ctx = new SubSuppliersContext(true);
            ctx.Customers.Add
            (
                new Customer
                {
                    Addresses = new[] 
                    { 
                        new Address
                        {
                            AddressType = new AddressType { Value = AddressTypeEnum.Billing },
                            CountryCode = new CountryCode { Value = CountryCodeType.PL },
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
                            MachineType = new MillingMachineType { Value = MillingMachineTypeEnum.TYPE_3 },
                            MillingMachineDimensionsType = new MillingMachineDimensionsType { Value = MillingMachineDimensionsTypeEnum.FIVE_AXIS },
                            Deleted = false,
                            MaximalMachiningDimensions = 5,
                            MinimalMachiningDimensions = 10,
                            Name = "SuperMachine2000"
                        },
                        new MillingMachine
                        {
                            MachineNumber = "TYPE_2",
                            MachineType = new MillingMachineType { Value = MillingMachineTypeEnum.TYPE_1 },
                            MillingMachineDimensionsType = new MillingMachineDimensionsType { Value = MillingMachineDimensionsTypeEnum.THREE_AXIS },
                            Deleted = false,
                            MaximalMachiningDimensions = 5,
                            MinimalMachiningDimensions = 5,
                            Name = "SuperMachine4000"
                        },
                        new MillingMachine
                        {
                            MachineNumber = "TYPE_3",
                            MachineType = new MillingMachineType { Value = MillingMachineTypeEnum.TYPE_2 },
                            MillingMachineDimensionsType = new MillingMachineDimensionsType { Value = MillingMachineDimensionsTypeEnum.THREE_PLUS_TWO_AXIS },
                            Deleted = false,
                            MaximalMachiningDimensions = 1,
                            MinimalMachiningDimensions = 2,
                            Name = "SuperMachine1000"
                        },
                    },
                    CompanySize = new CompanySize { Value = CompanySizeType.LessThan10 },
                    EmailAddress = "robert.shmidt@someCompany.com",
                    OtherTechnologies = new[]
                    {
                        new OtherTechnology { Value = OtherTechnologyTypeEnum.Annealing },
                        new OtherTechnology { Value = OtherTechnologyTypeEnum.DeepHoleDrilling },

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
                        new Certification
                        {
                            Value = CertificationTypeEnum.EN9100,
                        },
                        new Certification
                        {
                            Value = CertificationTypeEnum.ISO13485,
                        }
                    }
                }
            );

            bool result = await ctx.Customers.CheckIfEmailIsTaken("potepa.potepa@wp.pl");
            ctx.SaveChanges();
        }
    }
}
