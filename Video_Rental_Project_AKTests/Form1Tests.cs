using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_Rental_Project_AK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental_Project_AK.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Customer customer = new Customer();
            customer.name = "Rohit";customer.address = "NZ";customer.contact = "1234";
            String qry = "insert into customer(Name,Address,Contact)values('"+customer.name+"','"+customer.address+"','"+customer.contact+"')";
            if (customer.registerCustomer(qry))
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }


        [TestMethod()]
        public void Form2Test()
        {
            Customer customer = new Customer();
            customer.id = 1;
            
            String qry = "delete from customer where ID="+customer.id+"";
            if (customer.deleteCustomer(qry))
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}