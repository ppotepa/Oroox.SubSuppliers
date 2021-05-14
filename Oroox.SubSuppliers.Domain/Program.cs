using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Extensions;
using System.Linq;
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
                        Street = "Jakas ulica."
                    },
                    MillingMachines = new[]
                    {
                        new MillingMachine
                        {
                            MachineNumber = "TYPE_1",
                            MachineType = Entities.Enumerations.MillingMachineType.TYPE_1,
                            MillingMachineDimensionsType = MillingMachineDimensionsType.THREE_PLUS_TWO_AXIS
                        },
                        new MillingMachine
                        {
                            MachineNumber = "TYPE_2",
                            MachineType = Entities.Enumerations.MillingMachineType.TYPE_2,
                            MillingMachineDimensionsType = MillingMachineDimensionsType.THREE_AXIS
                        },
                        new MillingMachine
                        {
                            MachineNumber = "TYPE_3",
                            MachineType = Entities.Enumerations.MillingMachineType.TYPE_3,
                            MillingMachineDimensionsType = MillingMachineDimensionsType.FIVE_AXIS
                        },
                    }
                }
            );

            Customer firstUser = ctx.Customers.AsQueryable().First();
            var result = await ctx.Customers.CheckIfEmailIsTaken("potepa.potepa@wp.pl");
        }
    }
}
