using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using Oroox.SubSuppliers.Domain.Extensions;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Domain
{
    public class Program
    {
        public static async Task Main()
        {
            SubSuppliersContext ctx = new SubSuppliersContext();

            ctx.Customers.Add
            (
                new Customer
                {
                    Address = new Address
                    {
                        AddressType = Entities.Enumerations.AddressType.Billing,
                        CountryCodeType = Entities.Enumerations.CountryCodeType.AI,
                        Deleted = false,                        
                        PhoneNumber = "123, 123, 123",
                        Street = "Jakas ulica 20",
                    },
                    MillingMachines = new[]
                    {
                        new MillingMachine
                        {
                            MachineNumber = "TYPE_1",
                            MachineType = Entities.Enumerations.MillingMachineType.TYPE_1,
                            MillingMachineDimensionsType = MillingMachineDimensionsType.THREE_PLUS_TWO_AXIS,
                            Deleted = false, 
                            MaximalMachiningDimensions = 5,
                            MinimalMachiningDimensions = 10,
                            Name = "SuperMachine2000"
                        },
                        new MillingMachine
                        {
                            MachineNumber = "TYPE_2",
                            MachineType = Entities.Enumerations.MillingMachineType.TYPE_2,
                            MillingMachineDimensionsType = MillingMachineDimensionsType.THREE_AXIS,
                            Deleted = false,
                            MaximalMachiningDimensions = 5,
                            MinimalMachiningDimensions = 5,
                            Name = "SuperMachine4000"
                        },
                        new MillingMachine
                        {
                            MachineNumber = "TYPE_3",
                            MachineType = Entities.Enumerations.MillingMachineType.TYPE_3,
                            MillingMachineDimensionsType = MillingMachineDimensionsType.FIVE_AXIS,
                            Deleted = false,
                            MaximalMachiningDimensions = 1,
                            MinimalMachiningDimensions = 2,
                            Name = "SuperMachine1000"
                        },                        
                    },
                    CompanySize = Entities.Enumerations.CompanySizeType.LessThan10,
                    EmailAddress = "robert.shmidt@someCompany.com",
                    OtherTechnologies = new[] 
                    {
                        new OtherTechnology { Type = OtherTechnologyType.Annealing },
                        new OtherTechnology { Type = OtherTechnologyType.DeepHoleDrilling },

                    },
                    CompanyName = "Shmidt and Family",
                    RegistrationNumber = "00/01/2000",
                    VATNumber = "000-000-000-000-000",
                    Website = "http://shmidt-company.de",
                }
            );
            
            var result = await ctx.Customers.CheckIfEmailIsTaken("potepa.potepa@wp.pl");
            ctx.SaveChanges();
        }
    }
}
