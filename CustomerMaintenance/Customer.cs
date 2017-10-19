using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{

    public class Customer: ICloneable
	{
      
        public object Clone()
        {
            Customer c = new Customer();
            c.FirstName = this.FirstName;
            c.LastName = this.LastName;
            c.Email = this.Email;
            return c;
        }


		private string firstName;
		private string lastName;
		private string email;

		public Customer()
		{
		}

		public Customer(string firstName, string lastName, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
		}

		public string FirstName
		{
			get
			{
                return firstName;
			}
			set
			{
                if (value.Length > 30)
                {
                    throw new ArgumentException(
                        "Maximum length of first name is 30 characters.");
                }
                firstName = value;
			}
		}

		public string LastName
		{
			get
			{
                return lastName;
			}
			set
			{
                if (value.Length > 30)
                {
                    throw new ArgumentException(
                        "Maximum length of last name is 30 characters.");
                }
                lastName = value;
			}
		}

		public string Email
		{
			get
			{
				return email;
			}
			set
			{
                if (value.Length > 30)
                {
                    throw new ArgumentException(
                        "Maximum length of email address is 30 characters.");
                }
                email = value;
			}
		}

        /*public object Clone()
        {
            throw new NotImplementedException();
        }
        */
        public string GetDisplayText()
		{
			return firstName + " " + lastName + ", " + email;
		}
	}
}
