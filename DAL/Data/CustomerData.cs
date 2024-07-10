using AutoMapper;
using DAL.Dtos;
using DAL.Interface;
using Models.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class CustomerData:ICustomer
    {
        private readonly CustomerContext _context;
        private readonly IMapper _mapper;
        public CustomerData(CustomerContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CreateCustomer(CustomerDto c)
        {
            await _context.Customers.AddAsync(_mapper.Map<Customer>(c));
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteCustomer(long id)
        {
            Customer c = await _context.Customers.FindAsync(id);
            if (c == null)
            {
                return false;
            }

            _context.Customers.Remove(c);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Customer> GetCustomer(long id)
        {
            Customer c = await _context.Customers.FindAsync(id);
            if (c == null)
            {
                return null;
            }
            return c;
        }

        public async Task<bool> UpdateCustomer(long id, CustomerDto updatedCustomer)
        {
            Customer existingCustomer = await _context.Customers.FindAsync(id);
            if (existingCustomer == null)
            {
                return false;
            }

            existingCustomer.FirstName = updatedCustomer.FirstName;
            existingCustomer.LastName = updatedCustomer.LastName;
            existingCustomer.Phone = updatedCustomer.Phone;
            existingCustomer.PurchaseDate = updatedCustomer.PurchaseDate;
            existingCustomer.GModel = updatedCustomer.GModel;
            existingCustomer.GPD = updatedCustomer.GPD;
            existingCustomer.GRNumber = updatedCustomer.GRNumber;
            existingCustomer.GRcylinder = updatedCustomer.GRcylinder;
            existingCustomer.GRAxis = updatedCustomer.GRAxis;
            existingCustomer.GRAddition = updatedCustomer.GRAddition;
            existingCustomer.GRPrizma = updatedCustomer.GRPrizma;
            existingCustomer.GRindex = updatedCustomer.GRindex;
            existingCustomer.GLNumber = updatedCustomer.GLNumber;
            existingCustomer.GLcylinder = updatedCustomer.GLcylinder;
            existingCustomer.GLAxis = updatedCustomer.GLAxis;
            existingCustomer.GLAddition = updatedCustomer.GLAddition;
            existingCustomer.GLPrizma = updatedCustomer.GLPrizma;
            existingCustomer.GLIndex = updatedCustomer.GLIndex;
            existingCustomer.RNumber = updatedCustomer.RNumber;
            existingCustomer.Rcylinder = updatedCustomer.Rcylinder;
            existingCustomer.RAxis = updatedCustomer.RAxis;
            existingCustomer.RBC = updatedCustomer.RBC;
            existingCustomer.LNumber = updatedCustomer.LNumber;
            existingCustomer.Lcylinder = updatedCustomer.Lcylinder;
            existingCustomer.LAxis = updatedCustomer.LAxis;
            existingCustomer.LBC = updatedCustomer.LBC;
            existingCustomer.PreGPD = updatedCustomer.PreGPD;
            existingCustomer.PreGRNumber = updatedCustomer.PreGRNumber;
            existingCustomer.PreGRcylinder = updatedCustomer.PreGRcylinder;
            existingCustomer.PreGRAxis = updatedCustomer.PreGRAxis;
            existingCustomer.PreGRAddition = updatedCustomer.PreGRAddition;
            existingCustomer.PreGRPrizma = updatedCustomer.PreGRPrizma;
            existingCustomer.PreGRindex = updatedCustomer.PreGRindex;
            existingCustomer.PreGLNumber = updatedCustomer.PreGLNumber;
            existingCustomer.PreGLcylinder = updatedCustomer.PreGLcylinder;
            existingCustomer.PreGLAxis = updatedCustomer.PreGLAxis;
            existingCustomer.PreGLAddition = updatedCustomer.PreGLAddition;
            existingCustomer.PreGLPrizma = updatedCustomer.PreGLPrizma;
            existingCustomer.PreGLIndex = updatedCustomer.PreGLIndex;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
