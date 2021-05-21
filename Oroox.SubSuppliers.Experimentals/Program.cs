using AutoMapper;
using Oroox.SubSuppliers.Domain.Entities.Enumerations;
using System;

namespace Oroox.SubSuppliers.Experimentals
{
    class Program
    {
        class CustomerDTO 
        {
            public string Name { get; set; }
        }

        class Customer
        {
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            string type = CountryCodeTypeEnum.AD.ToString();
            Console.WriteLine(type);
        }
    }
}
