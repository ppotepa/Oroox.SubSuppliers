using Oroox.SubSuppliers.Domain.Context;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using Oroox.SubSuppliers.Domain.Entities.Enumerations.Technologies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroox.SubSuppliers.Domain
{
    public class Program
    {
        public static async Task Main()
        {          
            SubSuppliersContext ctx = new SubSuppliersContext(false);
            ctx.Add(NewCustomer(ctx, DateTime.Now.Millisecond));
            ctx.SaveChanges();
            var customer = ctx.Customers.First();

            ctx.Jobs.Add
            (
                new Job
                {
                    CustomerId = customer.Id,
                    SharedJobs = new List<SharedJob>()
                    {
                        new SharedJob
                        {
                            SharedJobStatusType = ctx.Enumerations.SharedJobStatusTypes[SharedJobStatusTypeEnum.UnansweredQuestions],
                            CustomerId = customer.Id,
                            Comments = new List<Comment>
                            {
                                new Comment
                                {
                                    Id = Guid.Parse("5697e683-90a4-4b4a-b224-d4cdf6bf2ddb"),
                                    CreatedBy = customer.Id,
                                    Text = "Some text",
                                    Attachment = new Attachment
                                    {
                                        Content = Encoding.ASCII.GetBytes("Some text content"),
                                        RegardingObject = new RegardingObject
                                        {
                                            EntityName = nameof(Comment),
                                            RegardingObjectId = Guid.Parse("5697e683-90a4-4b4a-b224-d4cdf6bf2ddb")
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            );

            //var comments = ctx.Comments.ToList();
            //var ctx2 = ctx.Find(comments[1].Attachment.RegardingObject.EntityType, comments[1].Attachment.RegardingObject.RegardingObjectId);
            //Comment comment = RegardingObject.Find<Comment>(ctx, comments[1].Attachment.RegardingObject.RegardingObjectId);
            //byte[] byteArray = comment.Attachment.Content;
            //string text = Encoding.Default.GetString(byteArray);
            
            ctx.SaveChanges();
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
