using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental_Project_AK
{
    public class Customer:ConnectionCls
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string contact { get; set; }

        public Boolean registerCustomer(String qry) {
            try
            {
                CmdQuery(qry);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
            
        }


        public Boolean deleteCustomer(String qry)
        {
            try
            {
                CmdQuery(qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public Boolean editCustomer(String qry)
        {
            try
            {
                CmdQuery(qry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }



    }
}
