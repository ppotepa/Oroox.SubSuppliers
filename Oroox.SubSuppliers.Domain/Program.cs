using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using Oroox.SubSuppliers.Domain.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Domain
{
    public class Program
    {
        public static async Task Main()
        {
            SubSuppliersContext ctx = new SubSuppliersContext(true);

            Dictionary<CompanySizeTypeEnum, CompanySizeType> companyTypes = ctx.CompanySizeTypes.ToDictionary(c => c.Value, c => c);
            Dictionary<CountryCodeTypeEnum, CountryCodeType> countryCodes = ctx.CountryCodeTypes.ToDictionary(c => c.Value, c => c);
            Dictionary<AddressTypeEnum, AddressType> addressTypes = ctx.AddressTypes.ToDictionary(c => c.Value, c => c);            
            Dictionary<OtherTechnologyTypeEnum, OtherTechnology> otherTechnologies = ctx.OtherTechnologies.ToDictionary(c => c.Value, c => c);            
            Dictionary<MillingMachineTypeEnum, MillingMachineType> millingMachineTypes = ctx.MillingMachineTypes.ToDictionary(c => c.Value, c => c);            
            Dictionary<MillingMachineDimensionsTypeEnum, MillingMachineDimensionsType> millingMachineDimensionsType = ctx.MillingMachineDimensionsTypes.ToDictionary(c => c.Value, c => c);            
            Dictionary<CertificationTypeEnum, Certification> certifications = ctx.Certifications.ToDictionary(c => c.Value, c => c);            

            ctx.Customers.Add
            (
                new Customer
                {
                    CompanySizeType = companyTypes[CompanySizeTypeEnum.LessThan10],
                
                Addresses = new[]
                {
                    new Address
                    {
                        AddressType = new AddressType { Value = AddressTypeEnum.Billing },
                        CountryCodeType = countryCodes[CountryCodeTypeEnum.AD],
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
                        MillingMachineType = millingMachineTypes[MillingMachineTypeEnum.TYPE_1],
                        MillingMachineDimensionsType = millingMachineDimensionsType[MillingMachineDimensionsTypeEnum.FIVE_AXIS],
                        Deleted = false,
                        MaximalMachiningDimensions = 5,
                        MinimalMachiningDimensions = 10,
                        Name = "SuperMachine2000"
                    },
                    new MillingMachine
                    {
                        MachineNumber = "TYPE_2",
                        MillingMachineType = millingMachineTypes[MillingMachineTypeEnum.TYPE_1],
                        MillingMachineDimensionsType = millingMachineDimensionsType[MillingMachineDimensionsTypeEnum.FIVE_AXIS],
                        Deleted = false,
                        MaximalMachiningDimensions = 5,
                        MinimalMachiningDimensions = 5,
                        Name = "SuperMachine4000"
                    },
                    new MillingMachine
                    {
                        MachineNumber = "TYPE_3",
                        MillingMachineType = millingMachineTypes[MillingMachineTypeEnum.TYPE_1],
                        MillingMachineDimensionsType = millingMachineDimensionsType[MillingMachineDimensionsTypeEnum.FIVE_AXIS],
                        Deleted = false,
                        MaximalMachiningDimensions = 1,
                        MinimalMachiningDimensions = 2,
                        Name = "SuperMachine1000"
                    },
                },                
                EmailAddress = "robert.shmidt@someCompany.com",
                OtherTechnologies = new[]
                {
                    otherTechnologies[OtherTechnologyTypeEnum.Annealing],
                    otherTechnologies[OtherTechnologyTypeEnum.Engravings],
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
            );

            bool result = await ctx.Customers.CheckIfEmailIsTaken("potepa.potepa@wp.pl");
            Customer firstCustomer = ctx.Customers.First();
            ctx.SaveChanges();
        }
    }
}
