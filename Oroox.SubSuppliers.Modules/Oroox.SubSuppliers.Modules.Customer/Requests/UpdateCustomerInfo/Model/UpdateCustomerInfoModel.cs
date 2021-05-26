using AutoMapper;
using Oroox.SubSuppliers.Domain.Entities;
using Oroox.SubSuppliers.Modules.Customers.Requests.UpdateCustomerInfo.DTO;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.UpdateCustomerInfo.Model
{
    public class UdateCustomerAdditionalInfoModel
    {
        public CustomerAdditionalInfoDTO CustomerAdditionalInfo { get; set; }
    }

    public class UdateCustomerAdditionalInfoProfile : Profile
    {
        public UdateCustomerAdditionalInfoProfile()
        {
            CreateMap<UdateCustomerAdditionalInfoModel, UpdateCustomerAdditionalInfoRequest>().ReverseMap();
            CreateMap<CustomerAdditionalInfoDTO, CustomerAdditionalInfo>().ReverseMap();
        }
    }

}