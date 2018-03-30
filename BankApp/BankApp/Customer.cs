using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Customer
    {
        string _firstName;
        string _lastname;
        string _accountnumber;

        public Customer(string firstName, string lastname, string accountnumber)
        {
            _firstName = firstName;
            _lastname = lastname;
            _accountnumber = accountnumber;
        }
        
        public string Firstname
        {
            get => _firstName; set => _firstName = value;
        }
        
        public string Lastname
        {
            get => _lastname; set => _lastname = value;
        }
        
        public string Accountnumber
        {
            get => _accountnumber; set => _accountnumber = value;
        }
    }
}
