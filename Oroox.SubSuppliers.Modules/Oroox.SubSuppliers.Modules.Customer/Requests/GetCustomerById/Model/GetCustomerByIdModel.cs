using Oroox.SubSuppliers.Modules.Customers.Requests.GetCustomerById.DTO;
using System;
using System.Collections.Generic;

namespace Oroox.SubSuppliers.Modules.Customers.Requests.GetCustomerById.Model
{
    public class GetCustomerByIdModel
    {
        public GetCustomerByIdDTO Customer { get; set; }
    }
 
    public class PeronModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<PeronModel2> Friends { get; set; }
    }

    public class PeronModel2
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}