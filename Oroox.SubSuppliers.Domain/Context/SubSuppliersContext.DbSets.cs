using Microsoft.EntityFrameworkCore;
using Oroox.SubSuppliers.Domain.Entities;
using System;
using System.Linq;

namespace Oroox.SubSuppliers.Domain.Context
{
    public partial class SubSuppliersContext : DbContext, IApplicationContext
    {
        private Type[] _currentEntities = default;
        public DbSet<CalculationDetails> CalculationDetails { get; set; }
        public DbSet<CustomerAdditionalInfo> CustomerAdditionalInfos { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<TurningMachine> Machines { get; set; }
        public DbSet<MillingMachine> MillingMachines { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<TurningMachine> TurningMachines { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        private Type[] CurrentEntities
        {
            get
            {
                if (_currentEntities is null)
                {
                    _currentEntities = currentAssemblyTypes.Where(t => t.IsSubclassOf(typeof(Entity))).ToArray();
                }
                return _currentEntities;
            }
        }
    }
}
