using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental_Project_AK
{
   public class booking:ConnectionCls
    {
        public int Bid { get; set; }
        public string Cid { get; set; }
        public string Mid { get; set; }
        public string BookingDt { get; set; }
        public string ReturnDt { get; set; }


        public Boolean registerBooking(String qry)
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


        public Boolean deleteBooking(String qry)
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

        public Boolean returnBooking(String qry)
        {
            try
            {
                CmdQuery(qry);

                DataTable tbl = new DataTable();
                tbl = CmdRecord("select * from video where Mid=" + Convert.ToInt32(Mid) + "");
                int Cost = Convert.ToInt32(tbl.Rows[0]["Cost"].ToString());


                DateTime current_date = DateTime.Now;

                //convert the old date from string to Date fromat
                DateTime prev_date = Convert.ToDateTime(BookingDt);


                //get the difference in the days fromat
                String Daysdiff = (current_date - prev_date).TotalDays.ToString();


                // calculate the round off value 
                Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));


                int total = Cost * Convert.ToInt32(DaysInterval);

                MessageBox.Show("Youur total Biil is $"+total);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


    }
}
