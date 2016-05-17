using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public int CVR { get; set; }
        public string CompanyAddress { get; set; }
        public string Phone { get; set; }

        public void setCustomer(localhost.Customer cust) {
            this.Id = cust.id;
            this.FirstName = cust.firstName;
            this.LastName = cust.lastName;
            this.CompanyName = cust.companyName;
            this.CVR = cust.cvr;
            this.CompanyAddress = cust.address;
            this.Phone = cust.telefone;
        }

        public localhost.Customer getCustomer()
        {
            localhost.Customer cust = new localhost.Customer();
            cust.id = this.Id;
            cust.firstName = this.FirstName;
            cust.lastName = this.LastName;
            cust.companyName = this.CompanyName;
            cust.cvr = this.CVR;
            cust.address = this.CompanyAddress;
            cust.telefone = this.Phone;
            return cust;
        }
    }
}