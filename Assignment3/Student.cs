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
        private bool _visible;

        public const string DefaultName = "John Doe";
        public Student(string name)
        {
            this._name = name;

        }

        public Student(double _iD, string name, string _emailAddress, bool _visible)
        {

            this._iD = _iD;
            this._name = name;
            this._emailAddress = _emailAddress;
            this._visible = _visible;
        }

        public double ID
        {
            get { return _iD; }
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
                if (_name != null)
                {
                    Console.WriteLine("Changing name from " + _name);
                    Console.WriteLine("to " + value);
                }
                _name = value;
            }

        }
        public bool Visible
        {
            get { return _visible; }

            private set
            {
                _visible = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                if(_visible == true)
                {
                    return _emailAddress;
                }
                return "Classified information";
            }

            set
            {
                if (Regex.IsMatch(value, "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"))
                {
                    if(_emailAddress != null)
                    {
                        Console.WriteLine("Changing email from " + _emailAddress);
                        Console.WriteLine("to " + value);
                    }
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
