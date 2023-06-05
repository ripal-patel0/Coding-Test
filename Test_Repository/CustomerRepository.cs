using Newtonsoft.Json;
using System;
using System.IO;
using Test_Modal;

namespace Test_Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        readonly string fileName = Environment.CurrentDirectory + @"\Customer.txt";
        public bool Save(CustomerDTOModal objCustomer)
        {
            string custometData = JsonConvert.SerializeObject(objCustomer);            
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    writer.Write(custometData + Environment.NewLine);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
