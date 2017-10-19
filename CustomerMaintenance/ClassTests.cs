using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CustomerMaintenance
{
    

    [TestFixture]
    class ClassTests
    {
        Customer c;
        private const string FNAME = "firstname";
        private const string LNAME = "lastname";
        private const string EMAIL = "email";
        [SetUp]
        public void SetUp()
        {
            c = new Customer(FNAME,LNAME,EMAIL);

        }

        [Test]
        public void TestClone()
        {
           
        }
    }
}
