using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental_Project_AK
{
    public partial class Form1 : Form
    {
        Customer customer = new Customer();
        
        Movie movie = new Movie();

        booking Booking = new booking();
        int BookingID = 0,choice=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        // add new customer to database 

        private void add_customer_button_Click(object sender, EventArgs e)
        {

            if (!customerName_textBox.Text.Equals("") && !C_Address_textBox.Text.Equals("") && !customer_contact_textbox.Text.Equals(""))
            {
                customer.name = customerName_textBox.Text;
                customer.address=C_Address_textBox.Text;
                customer.contact = customer_contact_textbox.Text;
                string qry = "insert into customer(Name,Address,Contact)values('"+customer.name+"','"+customer.address+"','"+customer.contact+"')";
                if (customer.registerCustomer(qry))
                {
                    MessageBox.Show("Record is sved ");
                    customer.name = "";
                    customer.address = "";
                    customer.contact = "";
                    customerName_textBox.Text = "";
                    C_Address_textBox.Text = "";
                    customer_contact_textbox.Text = "";
                }
                else {
                    MessageBox.Show("Need to verify the data once ");
                }
            }
            else {
                MessageBox.Show("You need to fill the details first ");
            }
        }

        // following button will delete video from database 

        private void del_customer_button_Click(object sender, EventArgs e)
        {

            if (!customer_id_textbox.Text.Equals("") && !customerName_textBox.Text.Equals("") && !C_Address_textBox.Text.Equals("") && !customer_contact_textbox.Text.Equals(""))
            {
                customer.id = Convert.ToInt32(customer_id_textbox.Text.ToString());
                customer.name = customerName_textBox.Text;
                customer.address = C_Address_textBox.Text;
                customer.contact = customer_contact_textbox.Text;

                string qry = "delete from customer where ID="+customer.id+"";
                if (customer.deleteCustomer(qry))
                {
                    MessageBox.Show("Record is removed ");
                    customer.id = 0;
                    customer.name = "";
                    customer.address = "";
                    customer.contact = "";
                    customerName_textBox.Text = "";
                    C_Address_textBox.Text = "";
                    customer_contact_textbox.Text = "";
                    customer_id_textbox.Text = "";
                }
                else
                {
                    MessageBox.Show("Need to verify the data once ");
                }
            }
            else
            {
                MessageBox.Show("You need to fill the details first ");
            }
        }

        // to update new customers to database 

        private void update_button_Click(object sender, EventArgs e)
        {
            if (!customer_id_textbox.Text.Equals("") && !customerName_textBox.Text.Equals("") && !C_Address_textBox.Text.Equals("") && !customer_contact_textbox.Text.Equals(""))
            {
                customer.id = Convert.ToInt32(customer_id_textbox.Text.ToString());
                customer.name = customerName_textBox.Text;
                customer.address = C_Address_textBox.Text;
                customer.contact = customer_contact_textbox.Text;
                
                string qry = "update customer set Name='"+customer.name+"', Address='"+customer.address+"',Contact='"+customer.contact+"' where ID=" + customer.id + "";
                if (customer.editCustomer(qry))
                {
                    MessageBox.Show("Record is Updated ");
                    customer.id = 0;
                    customer.name = "";
                    customer.address = "";
                    customer.contact = "";
                    customerName_textBox.Text = "";
                    C_Address_textBox.Text = "";
                    customer_contact_textbox.Text = "";
                    customer_id_textbox.Text = "";
                }
                else
                {
                    MessageBox.Show("Need to verify the data once ");
                }
            }
            else
            {
                MessageBox.Show("You need to fill the details first ");
            }

        }

        // it will insert video to data base 

        private void add_video_button_Click(object sender, EventArgs e)
        {
            if (!video_name_textBox.Text.Equals("") && !video_Ratting_TextBox.Text.Equals("") && !year_textBox.Text.Equals("") && !cost_text_box.Text.Equals("") && ! video_copy.Text.Equals("") && !plot_textBox.Text.Equals("") && !genre_textBox.Text.Equals("")) {
                
                movie.name = video_name_textBox.Text;
                movie.ratting = video_Ratting_TextBox.Text;
                movie.year = year_textBox.Text;
                movie.cost = cost_text_box.Text;
                movie.copies = video_copy.Text;
                movie.plot = plot_textBox.Text;
                movie.genre = genre_textBox.Text;

                string qry = "insert into Video(Name,Ratting,Year,Cost,Copy,Plot,Genre)values('"+movie.name+"','"+movie.ratting+"','"+movie.year+"','"+movie.cost+"','"+movie.copies+"','"+movie.plot+"','"+movie.genre+"')";
                if (movie.registerMovie(qry))
                {

                    movie.name = ""; video_name_textBox.Text = "" ;
                    movie.ratting = ""; video_Ratting_TextBox.Text="";
                    movie.year = ""; year_textBox.Text="";
                    movie.cost = ""; cost_text_box.Text = "";
                    movie.copies = ""; video_copy.Text="";
                    movie.plot = ""; plot_textBox.Text="";
                    movie.genre = ""; genre_textBox.Text="";
                    video_id_textBox.Text = "";


                    MessageBox.Show("Movie record is saved ");
                }
                else {
                    MessageBox.Show("Check Once again ");

                }



            }
            else {
                MessageBox.Show("you need to fill the details first ");
            }
        }

        // delete videos from database 

        private void delete_button_videos_Click(object sender, EventArgs e)
        {
            if (!video_id_textBox.Text.Equals("") && !video_name_textBox.Text.Equals("") && !video_Ratting_TextBox.Text.Equals("") && !year_textBox.Text.Equals("") && !cost_text_box.Text.Equals("") && !video_copy.Text.Equals("") && !plot_textBox.Text.Equals("") && !genre_textBox.Text.Equals(""))
            {
                movie.Mid = Convert.ToInt32(video_id_textBox.Text);

                movie.name = video_name_textBox.Text;
                movie.ratting = video_Ratting_TextBox.Text;
                movie.year = year_textBox.Text;
                movie.cost = cost_text_box.Text;
                movie.copies = video_copy.Text;
                movie.plot = plot_textBox.Text;
                movie.genre = genre_textBox.Text;

                string qry = "delete from  Video where Mid="+movie.Mid+"";
                if (movie.deleteMovie(qry))
                {

                    movie.name = ""; video_name_textBox.Text = "";
                    movie.ratting = ""; video_Ratting_TextBox.Text = "";
                    movie.year = ""; year_textBox.Text = "";
                    movie.cost = ""; cost_text_box.Text = "";
                    movie.copies = ""; video_copy.Text = "";
                    movie.plot = ""; plot_textBox.Text = "";
                    movie.genre = ""; genre_textBox.Text = "";
                    movie.Mid = 0; video_id_textBox.Text = "";


                    MessageBox.Show("Movie record is removed ");
                }
                else
                {
                    MessageBox.Show("Check Once again ");

                }



            }
            else
            {
                MessageBox.Show("you need to fill the details first ");
            }
        }

        // update video button 

        private void update_video_button_Click(object sender, EventArgs e)
        {
            if (!video_id_textBox.Text.Equals("") && !video_name_textBox.Text.Equals("") && !video_Ratting_TextBox.Text.Equals("") && !year_textBox.Text.Equals("") && !cost_text_box.Text.Equals("") && !video_copy.Text.Equals("") && !plot_textBox.Text.Equals("") && !genre_textBox.Text.Equals(""))
            {
                movie.Mid = Convert.ToInt32(video_id_textBox.Text);

                movie.name = video_name_textBox.Text;
                movie.ratting = video_Ratting_TextBox.Text;
                movie.year = year_textBox.Text;
                movie.cost = cost_text_box.Text;
                movie.copies = video_copy.Text;
                movie.plot = plot_textBox.Text;
                movie.genre = genre_textBox.Text;

                string qry = "update  Video set Name='"+movie.name+"',Ratting='"+movie.ratting+"',Year='"+movie.year+"',Cost='"+movie.cost+"',Copy='"+movie.copies+"',Plot='"+movie.plot+"',Genre='"+movie.genre+"'  where Mid=" + movie.Mid + "";
                if (movie.deleteMovie(qry))
                {

                    movie.name = ""; video_name_textBox.Text = "";
                    movie.ratting = ""; video_Ratting_TextBox.Text = "";
                    movie.year = ""; year_textBox.Text = "";
                    movie.cost = ""; cost_text_box.Text = "";
                    movie.copies = ""; video_copy.Text = "";
                    movie.plot = ""; plot_textBox.Text = "";
                    movie.genre = ""; genre_textBox.Text = "";
                    movie.Mid = 0; video_id_textBox.Text = "";


                    MessageBox.Show("Movie record is Updated");
                }
                else
                {
                    MessageBox.Show("Check Once again ");

                }



            }
            else
            {
                MessageBox.Show("you need to fill the details first ");
            }
        }

        // issue of button will issue movie according to customer id and movie id 

        private void issue_btn_Click(object sender, EventArgs e)
        {
            if (!video_id_textBox.Text.Equals("") && !customer_id_textbox.Text.Equals(""))
            {
                Booking.Cid = customer_id_textbox.Text;
                Booking.Mid = video_id_textBox.Text;
                Booking.BookingDt = issue_date_picker.Text;
                Booking.ReturnDt = "Issue";
                String qry = "insert into Booking(Cid,Mid,BookingDt,ReturnDt)values('"+Booking.Cid+"','"+Booking.Mid+"','"+Booking.BookingDt+"','"+Booking.ReturnDt+"')";
                if (Booking.registerBooking(qry))
                {
                    MessageBox.Show("Video is Issued on Rent");
                    Booking.Cid = ""; customer_id_textbox.Text="";
                    Booking.Mid = ""; video_id_textBox.Text="";
                    Booking.BookingDt = "";
                    Booking.ReturnDt = "";

                    customer.id = 0;
                    customer.name = "";
                    customer.address = "";
                    customer.contact = "";
                    customerName_textBox.Text = "";
                    C_Address_textBox.Text = "";
                    customer_contact_textbox.Text = "";
                    customer_id_textbox.Text = "";

                    movie.name = ""; video_name_textBox.Text = "";
                    movie.ratting = ""; video_Ratting_TextBox.Text = "";
                    movie.year = ""; year_textBox.Text = "";
                    movie.cost = ""; cost_text_box.Text = "";
                    movie.copies = ""; video_copy.Text = "";
                    movie.plot = ""; plot_textBox.Text = "";
                    movie.genre = ""; genre_textBox.Text = "";
                    video_id_textBox.Text = "";

                }
                else {
                    MessageBox.Show("Check Once ");
                }

            }
            else {
                MessageBox.Show("need to select the movie and customer for booking ");
            }
        }

        // return movie changing status of booked to date of retrun and will show the price according to days

        private void return_movie_buton_Click(object sender, EventArgs e)
        {

            if (BookingID>0 && !video_id_textBox.Text.Equals("") && !customer_id_textbox.Text.Equals(""))
            {
                Booking.Bid = BookingID;
                Booking.Cid = customer_id_textbox.Text;
                Booking.Mid = video_id_textBox.Text;
                Booking.BookingDt = issue_date_picker.Text;
                Booking.ReturnDt = return_date_picker.Text;
                String qry = "update Booking set Cid='" + Booking.Cid + "',Mid='" + Booking.Mid + "',BookingDt='" + Booking.BookingDt + "',ReturnDt='" + Booking.ReturnDt + "' where Bid="+Booking.Bid+"";
                if (Booking.returnBooking(qry))
                {
                    MessageBox.Show("Video is returned ");
                    Booking.Cid = ""; customer_id_textbox.Text = "";
                    Booking.Mid = ""; video_id_textBox.Text = "";
                    Booking.BookingDt = "";
                    Booking.ReturnDt = "";
                    Booking.Bid = 0;BookingID = 0;


                    customer.id = 0;
                    customer.name = "";
                    customer.address = "";
                    customer.contact = "";
                    customerName_textBox.Text = "";
                    C_Address_textBox.Text = "";
                    customer_contact_textbox.Text = "";
                    customer_id_textbox.Text = "";

                    movie.name = ""; video_name_textBox.Text = "";
                    movie.ratting = ""; video_Ratting_TextBox.Text = "";
                    movie.year = ""; year_textBox.Text = "";
                    movie.cost = ""; cost_text_box.Text = "";
                    movie.copies = ""; video_copy.Text = "";
                    movie.plot = ""; plot_textBox.Text = "";
                    movie.genre = ""; genre_textBox.Text = "";
                    video_id_textBox.Text = "";


                }
                else
                {
                    MessageBox.Show("Check Once ");
                }

            }
            else
            {
                MessageBox.Show("need to select the movie and customer for booking ");
            }
        }

        // delete movie will delete record from database

        private void DELETE_movie_buton_Click(object sender, EventArgs e)
        {
            if (BookingID > 0 && !video_id_textBox.Text.Equals("") && !customer_id_textbox.Text.Equals(""))
            {
                Booking.Bid = BookingID;
                Booking.Cid = customer_id_textbox.Text;
                Booking.Mid = video_id_textBox.Text;
                Booking.BookingDt = issue_date_picker.Text;
                Booking.ReturnDt = return_date_picker.Text;
                String qry = "delete Booking  where Bid=" + Booking.Bid + "";
                if (Booking.deleteBooking(qry))
                {
                    MessageBox.Show("Booking Video is deleted ");
                    Booking.Cid = ""; customer_id_textbox.Text = "";
                    Booking.Mid = ""; video_id_textBox.Text = "";
                    Booking.BookingDt = "";
                    Booking.ReturnDt = "";
                    Booking.Bid = 0; BookingID = 0;

                    customer.id = 0;
                    customer.name = "";
                    customer.address = "";
                    customer.contact = "";
                    customerName_textBox.Text = "";
                    C_Address_textBox.Text = "";
                    customer_contact_textbox.Text = "";
                    customer_id_textbox.Text = "";

                    movie.name = ""; video_name_textBox.Text = "";
                    movie.ratting = ""; video_Ratting_TextBox.Text = "";
                    movie.year = ""; year_textBox.Text = "";
                    movie.cost = ""; cost_text_box.Text = "";
                    movie.copies = ""; video_copy.Text = "";
                    movie.plot = ""; plot_textBox.Text = "";
                    movie.genre = ""; genre_textBox.Text = "";
                    video_id_textBox.Text = "";


                }
                else
                {
                    MessageBox.Show("Check Once ");
                }

            }
            else
            {
                MessageBox.Show("need to select the movie and customer for booking ");
            }
        }

        // customer storted button will make customer adding textbox appear

        private void customers_Stored_button_Click(object sender, EventArgs e)
        {
            customer_group.Visible = true;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            
        }

        // it will make visible group box of rental part

        private void rental_stored_button_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false;
            customer_group.Visible = false;

        }

        // this will display part of video add area

        private void best_video_butn_Click(object sender, EventArgs e)
        {

            //compare the booking and fetch the most viewed movie
            DataTable tblData = new DataTable();
            

            tblData = Booking.CmdRecord("select * from Video");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = Booking.CmdRecord("select * from Booking where Mid='" + tblData.Rows[x]["Mid"].ToString() + "'");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Best Movie is " + Title);




        }

        private void year_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(year_textBox.Text);
                int cost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    cost = 5;
                }

                cost_text_box.Text = "" + cost;
            }
            catch (Exception ex)
            {

            }

        }

        private void data_show_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (choice) {
                case 1:
                    video_id_textBox.Text = data_show_grid.CurrentRow.Cells[0].Value.ToString();
                    video_name_textBox.Text = data_show_grid.CurrentRow.Cells[1].Value.ToString();
                    video_Ratting_TextBox.Text = data_show_grid.CurrentRow.Cells[2].Value.ToString();
                    year_textBox.Text = data_show_grid.CurrentRow.Cells[3].Value.ToString();
                    cost_text_box.Text = data_show_grid.CurrentRow.Cells[4].Value.ToString();
                    video_copy.Text = data_show_grid.CurrentRow.Cells[5].Value.ToString();
                    plot_textBox.Text = data_show_grid.CurrentRow.Cells[6].Value.ToString();
                    genre_textBox.Text = data_show_grid.CurrentRow.Cells[7].Value.ToString();

                    break;
                case 2:
                    customer_id_textbox.Text = data_show_grid.CurrentRow.Cells[0].Value.ToString();
                    customerName_textBox.Text = data_show_grid.CurrentRow.Cells[1].Value.ToString();
                    C_Address_textBox.Text = data_show_grid.CurrentRow.Cells[2].Value.ToString();
                    customer_contact_textbox.Text = data_show_grid.CurrentRow.Cells[3].Value.ToString();

                    break;
                case 3:
                    BookingID=Convert.ToInt32( data_show_grid.CurrentRow.Cells[0].Value.ToString());
                    customer_id_textbox.Text = data_show_grid.CurrentRow.Cells[1].Value.ToString();
                    video_id_textBox.Text = data_show_grid.CurrentRow.Cells[2].Value.ToString();
                    issue_date_picker.Text = data_show_grid.CurrentRow.Cells[3].Value.ToString();


                    break;
                default:
                break;
            }
            choice = 0;

        }

        private void best_customer_btn_Click(object sender, EventArgs e)
        {
            //compare the booking and fetch the most viewed movie
            DataTable tblData = new DataTable();


            tblData = Booking.CmdRecord("select * from Customer");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = Booking.CmdRecord("select * from Booking where Cid='" + tblData.Rows[x]["ID"].ToString() + "'");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Best Customer Name is " + Title);


        }

        private void btnRetnalView_Click(object sender, EventArgs e)
        {

            choice = 3;
            DataTable tbl = new DataTable();
            String qry = "select * from Booking";
            tbl = movie.CmdRecord(qry);
            data_show_grid.DataSource = tbl;
        }

        private void btnVideoView_Click(object sender, EventArgs e)
        {
            choice = 1;
            DataTable tbl = new DataTable();
            String qry = "select * from Video";
            tbl = movie.CmdRecord(qry);
            data_show_grid.DataSource = tbl;

        }

        private void btnCustomerView_Click(object sender, EventArgs e)
        {
            choice = 2;
            DataTable tbl = new DataTable();
            String qry = "select * from Customer";
            tbl = customer.CmdRecord(qry);
            data_show_grid.DataSource = tbl;
        }

        private void btn_videos_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            customer_group.Visible = false;
            groupBox3.Visible = false;

        }
    }
}
