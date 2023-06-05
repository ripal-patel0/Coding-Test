using System;
using System.Collections.Generic;
using System.Text;
using Test_Modal;
namespace Test_Repository
{
    public interface ICustomerRepository
    {
        public bool Save(CustomerDTOModal objCustomer);
    }
}
