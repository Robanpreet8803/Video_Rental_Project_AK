using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental_Project_AK
{
   public class Movie :ConnectionCls
    {
        public int Mid { get; set; }
        public string name { get; set; }
        public string ratting { get; set; }

        public string year { get; set; }
        public string cost { get; set; }
        public string copies { get; set; }
        public string plot { get; set; }

        public string genre { get; set; }



        public Boolean registerMovie(String qry)
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


        public Boolean deleteMovie(String qry)
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

        public Boolean editMovie(String qry)
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
