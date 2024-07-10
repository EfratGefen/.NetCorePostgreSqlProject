using AutoMapper;
using DAL.Dtos;
using Models.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Profiles
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerDto, Customer>();
            CreateMap<Customer,CustomerDto>();
        }
    }
}
