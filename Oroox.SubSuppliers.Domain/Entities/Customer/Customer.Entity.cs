using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Oroox.SubSuppliers.Domain.Entities
{
    public partial class Customer : User
    {
        private List<MillingMachine> millingMachines;

        private List<TurningMachine> turningMachines;        

        public Customer() { }
        public Customer
        (
             string companyName,
             CompanySizeType companySizeType,
             List<Address> addresses,
             List<Machine> machines,
             string vatNumber,
             string website,
             string registrationNumber             
        )
        {
            CompanyName = companyName;
            CompanySizeType = companySizeType;
            Addresses = addresses;
            Machines = machines;
            VATNumber = vatNumber;
            Website = website;
            RegistrationNumber = registrationNumber;            
        }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Certification> Certifications { get; set; }
        public virtual List<SharedJob> SharedJobs { get; set; }
        public string CompanyName { get; set; }
        public virtual CompanySizeType CompanySizeType { get; set; }
        public virtual CustomerAdditionalInfo CustomerAdditionalInfo { get; set; }        
        public bool IsActive { get; set; }
        public virtual List<Machine> Machines { get; set; }

        [NotMapped]
        public virtual List<MillingMachine> MillingMachines
        {
            get
            {
                if (this.Machines is null)
                    millingMachines = new List<MillingMachine>();
                else
                    millingMachines = this.Machines.OfType<MillingMachine>().ToList();

                return millingMachines;
            }
            set => millingMachines = value;
        }

        public virtual ICollection<OtherTechnology> OtherTechnologies { get; set; }
        [NotMapped]
        public string Password { get; set; }

        [NotMapped]
        public string PasswordConfirmation { get; set; }

        public string PasswordHash { get; set; }

        public virtual Registration Registration { get; set; }

        public string RegistrationNumber { get; set; }

        [NotMapped]
        public virtual List<TurningMachine> TurningMachines
        {
            get
            {
                if (this.Machines is null)
                    turningMachines = new List<TurningMachine>();
                else
                    turningMachines = new List<TurningMachine>();

                return turningMachines;
            }
            set => turningMachines = value;
        }
        public string VATNumber { get; set; }
        public string Website { get; set; }
        #region FOREIGN_KEYS
        public Guid CompanySizeTypeId { get; set; }
        #endregion

        public override string Name 
        {
            get => CompanyName; 
            set => Name = value;
        }
    }
}
