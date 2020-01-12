using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Core_Flexible_Object_Mapping.Models
{
   public class Person
    {
        public int PersonId { get; set; }
        public string FisrtName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        private string _Email;

        public void SetEmail(string email)
        {
            _Email = email;
        }

        public string GetEmail()
        {
            return _Email;
        }

        private string _ContactNo;

        public void SetContactNo(string contact)
        {
            _ContactNo = contact;
        }

        public string GetContact()
        {
            return _ContactNo;
        }
    }
}
