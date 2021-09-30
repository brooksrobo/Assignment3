using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assignment3
{
    class Student
    {
        private double _iD;
        private string _name;
        private string _emailAddress;

        public Student()
        {
            this._iD = 0;
            this._name = "John Doe";
            this._emailAddress = "John.Doe@gmail.com";
        }

        public Student(double iD, string name, string _emailAddress)
        {
            this._iD = iD;
            this._name = name;
            this._emailAddress = EmailAddress;
        }

        public double ID
        {
            get { return _iD; }

            set
            {
                if (double.IsNaN(value))
                {
                    throw new Exception("ID must be a number");
                }
                _iD = value;
            }
        }

        public string Name
        {
            get { return _name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name required.");
                }
                _name = value;
            }

        }
        public string EmailAddress
        {
            
            get { return _emailAddress; }
           
            set
            {
                if (Regex.IsMatch(value, "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"))
                {
                    _emailAddress = value;
                }
                else
                {
                    throw new Exception("Email address must follow a valid format.");
                }
            }
        }
    }
}
