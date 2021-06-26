
namespace Video_Rental_Project_AK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_show_grid = new System.Windows.Forms.DataGridView();
            this.btn_videos = new System.Windows.Forms.Button();
            this.customers_Stored_button = new System.Windows.Forms.Button();
            this.rental_stored_button = new System.Windows.Forms.Button();
            this.best_video_butn = new System.Windows.Forms.Button();
            this.best_customer_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRetnalView = new System.Windows.Forms.Button();
            this.return_date_picker = new System.Windows.Forms.DateTimePicker();
            this.issue_date_picker = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.DELETE_movie_buton = new System.Windows.Forms.Button();
            this.return_movie_buton = new System.Windows.Forms.Button();
            this.issue_btn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.video_id_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.customer_id_textbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVideoView = new System.Windows.Forms.Button();
            this.cost_text_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.delete_button_videos = new System.Windows.Forms.Button();
            this.update_video_button = new System.Windows.Forms.Button();
            this.add_video_button = new System.Windows.Forms.Button();
            this.genre_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.plot_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.video_copy = new System.Windows.Forms.TextBox();
            this.year_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.video_Ratting_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.video_name_textBox = new System.Windows.Forms.TextBox();
            this.customer_group = new System.Windows.Forms.GroupBox();
            this.btnCustomerView = new System.Windows.Forms.Button();
            this.del_customer_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.add_customer_button = new System.Windows.Forms.Button();
            this.customer_contact_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.C_Address_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerName_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_show_grid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.customer_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_show_grid
            // 
            this.data_show_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_show_grid.Location = new System.Drawing.Point(37, 58);
            this.data_show_grid.Name = "data_show_grid";
            this.data_show_grid.Size = new System.Drawing.Size(933, 218);
            this.data_show_grid.TabIndex = 0;
            this.data_show_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_show_grid_CellClick);
            // 
            // btn_videos
            // 
            this.btn_videos.BackColor = System.Drawing.Color.Blue;
            this.btn_videos.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_videos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_videos.Location = new System.Drawing.Point(37, 2);
            this.btn_videos.Name = "btn_videos";
            this.btn_videos.Size = new System.Drawing.Size(160, 50);
            this.btn_videos.TabIndex = 1;
            this.btn_videos.Text = "Videos Stored";
            this.btn_videos.UseVisualStyleBackColor = false;
            this.btn_videos.Click += new System.EventHandler(this.btn_videos_Click);
            // 
            // customers_Stored_button
            // 
            this.customers_Stored_button.BackColor = System.Drawing.Color.Blue;
            this.customers_Stored_button.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_Stored_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customers_Stored_button.Location = new System.Drawing.Point(213, 2);
            this.customers_Stored_button.Name = "customers_Stored_button";
            this.customers_Stored_button.Size = new System.Drawing.Size(206, 50);
            this.customers_Stored_button.TabIndex = 2;
            this.customers_Stored_button.Text = "Customers Stored";
            this.customers_Stored_button.UseVisualStyleBackColor = false;
            this.customers_Stored_button.Click += new System.EventHandler(this.customers_Stored_button_Click);
            // 
            // rental_stored_button
            // 
            this.rental_stored_button.BackColor = System.Drawing.Color.Blue;
            this.rental_stored_button.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_stored_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rental_stored_button.Location = new System.Drawing.Point(436, 2);
            this.rental_stored_button.Name = "rental_stored_button";
            this.rental_stored_button.Size = new System.Drawing.Size(206, 50);
            this.rental_stored_button.TabIndex = 3;
            this.rental_stored_button.Text = "Rentals Stored";
            this.rental_stored_button.UseVisualStyleBackColor = false;
            this.rental_stored_button.Click += new System.EventHandler(this.rental_stored_button_Click);
            // 
            // best_video_butn
            // 
            this.best_video_butn.BackColor = System.Drawing.Color.Blue;
            this.best_video_butn.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_video_butn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.best_video_butn.Location = new System.Drawing.Point(648, 2);
            this.best_video_butn.Name = "best_video_butn";
            this.best_video_butn.Size = new System.Drawing.Size(139, 50);
            this.best_video_butn.TabIndex = 4;
            this.best_video_butn.Text = "Best Video";
            this.best_video_butn.UseVisualStyleBackColor = false;
            this.best_video_butn.Click += new System.EventHandler(this.best_video_butn_Click);
            // 
            // best_customer_btn
            // 
            this.best_customer_btn.BackColor = System.Drawing.Color.Blue;
            this.best_customer_btn.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.best_customer_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.best_customer_btn.Location = new System.Drawing.Point(793, 2);
            this.best_customer_btn.Name = "best_customer_btn";
            this.best_customer_btn.Size = new System.Drawing.Size(177, 50);
            this.best_customer_btn.TabIndex = 5;
            this.best_customer_btn.Text = "Best Customer";
            this.best_customer_btn.UseVisualStyleBackColor = false;
            this.best_customer_btn.Click += new System.EventHandler(this.best_customer_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRetnalView);
            this.groupBox3.Controls.Add(this.return_date_picker);
            this.groupBox3.Controls.Add(this.issue_date_picker);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.DELETE_movie_buton);
            this.groupBox3.Controls.Add(this.return_movie_buton);
            this.groupBox3.Controls.Add(this.issue_btn);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.video_id_textBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.customer_id_textbox);
            this.groupBox3.Location = new System.Drawing.Point(37, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(857, 112);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rental Details";
            this.groupBox3.Visible = false;
            // 
            // btnRetnalView
            // 
            this.btnRetnalView.BackColor = System.Drawing.Color.Blue;
            this.btnRetnalView.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetnalView.ForeColor = System.Drawing.Color.White;
            this.btnRetnalView.Location = new System.Drawing.Point(340, 70);
            this.btnRetnalView.Name = "btnRetnalView";
            this.btnRetnalView.Size = new System.Drawing.Size(102, 38);
            this.btnRetnalView.TabIndex = 13;
            this.btnRetnalView.Text = "View";
            this.btnRetnalView.UseVisualStyleBackColor = false;
            this.btnRetnalView.Click += new System.EventHandler(this.btnRetnalView_Click);
            // 
            // return_date_picker
            // 
            this.return_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.return_date_picker.Location = new System.Drawing.Point(656, 58);
            this.return_date_picker.Name = "return_date_picker";
            this.return_date_picker.Size = new System.Drawing.Size(161, 20);
            this.return_date_picker.TabIndex = 12;
            // 
            // issue_date_picker
            // 
            this.issue_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.issue_date_picker.Location = new System.Drawing.Point(471, 58);
            this.issue_date_picker.Name = "issue_date_picker";
            this.issue_date_picker.Size = new System.Drawing.Size(161, 20);
            this.issue_date_picker.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(693, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 21);
            this.label15.TabIndex = 9;
            this.label15.Text = "Return Date";
            // 
            // DELETE_movie_buton
            // 
            this.DELETE_movie_buton.BackColor = System.Drawing.Color.Blue;
            this.DELETE_movie_buton.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE_movie_buton.ForeColor = System.Drawing.Color.White;
            this.DELETE_movie_buton.Location = new System.Drawing.Point(223, 72);
            this.DELETE_movie_buton.Name = "DELETE_movie_buton";
            this.DELETE_movie_buton.Size = new System.Drawing.Size(102, 38);
            this.DELETE_movie_buton.TabIndex = 8;
            this.DELETE_movie_buton.Text = "DELETE";
            this.DELETE_movie_buton.UseVisualStyleBackColor = false;
            this.DELETE_movie_buton.Click += new System.EventHandler(this.DELETE_movie_buton_Click);
            // 
            // return_movie_buton
            // 
            this.return_movie_buton.BackColor = System.Drawing.Color.Blue;
            this.return_movie_buton.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_movie_buton.ForeColor = System.Drawing.Color.White;
            this.return_movie_buton.Location = new System.Drawing.Point(115, 72);
            this.return_movie_buton.Name = "return_movie_buton";
            this.return_movie_buton.Size = new System.Drawing.Size(102, 36);
            this.return_movie_buton.TabIndex = 7;
            this.return_movie_buton.Text = "RETURN";
            this.return_movie_buton.UseVisualStyleBackColor = false;
            this.return_movie_buton.Click += new System.EventHandler(this.return_movie_buton_Click);
            // 
            // issue_btn
            // 
            this.issue_btn.BackColor = System.Drawing.Color.Blue;
            this.issue_btn.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_btn.ForeColor = System.Drawing.Color.White;
            this.issue_btn.Location = new System.Drawing.Point(6, 70);
            this.issue_btn.Name = "issue_btn";
            this.issue_btn.Size = new System.Drawing.Size(103, 38);
            this.issue_btn.TabIndex = 6;
            this.issue_btn.Text = "ISSUE";
            this.issue_btn.UseVisualStyleBackColor = false;
            this.issue_btn.Click += new System.EventHandler(this.issue_btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(511, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Issue Date";
            // 
            // video_id_textBox
            // 
            this.video_id_textBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_id_textBox.Location = new System.Drawing.Point(247, 34);
            this.video_id_textBox.Name = "video_id_textBox";
            this.video_id_textBox.Size = new System.Drawing.Size(122, 32);
            this.video_id_textBox.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(184, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "VD id";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "CM id";
            // 
            // customer_id_textbox
            // 
            this.customer_id_textbox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id_textbox.Location = new System.Drawing.Point(68, 32);
            this.customer_id_textbox.Name = "customer_id_textbox";
            this.customer_id_textbox.Size = new System.Drawing.Size(110, 32);
            this.customer_id_textbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVideoView);
            this.groupBox2.Controls.Add(this.cost_text_box);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.delete_button_videos);
            this.groupBox2.Controls.Add(this.update_video_button);
            this.groupBox2.Controls.Add(this.add_video_button);
            this.groupBox2.Controls.Add(this.genre_textBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.plot_textBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.video_copy);
            this.groupBox2.Controls.Add(this.year_textBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.video_Ratting_TextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.video_name_textBox);
            this.groupBox2.Location = new System.Drawing.Point(37, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 162);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Video Details";
            this.groupBox2.Visible = false;
            // 
            // btnVideoView
            // 
            this.btnVideoView.BackColor = System.Drawing.Color.Blue;
            this.btnVideoView.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVideoView.Location = new System.Drawing.Point(546, 112);
            this.btnVideoView.Name = "btnVideoView";
            this.btnVideoView.Size = new System.Drawing.Size(87, 44);
            this.btnVideoView.TabIndex = 19;
            this.btnVideoView.Text = "View";
            this.btnVideoView.UseVisualStyleBackColor = false;
            this.btnVideoView.Click += new System.EventHandler(this.btnVideoView_Click);
            // 
            // cost_text_box
            // 
            this.cost_text_box.Enabled = false;
            this.cost_text_box.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_text_box.Location = new System.Drawing.Point(747, 76);
            this.cost_text_box.Name = "cost_text_box";
            this.cost_text_box.Size = new System.Drawing.Size(104, 32);
            this.cost_text_box.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(667, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "VM Cost";
            // 
            // delete_button_videos
            // 
            this.delete_button_videos.BackColor = System.Drawing.Color.Blue;
            this.delete_button_videos.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button_videos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_button_videos.Location = new System.Drawing.Point(445, 112);
            this.delete_button_videos.Name = "delete_button_videos";
            this.delete_button_videos.Size = new System.Drawing.Size(87, 44);
            this.delete_button_videos.TabIndex = 8;
            this.delete_button_videos.Text = "DELETE";
            this.delete_button_videos.UseVisualStyleBackColor = false;
            this.delete_button_videos.Click += new System.EventHandler(this.delete_button_videos_Click);
            // 
            // update_video_button
            // 
            this.update_video_button.BackColor = System.Drawing.Color.Blue;
            this.update_video_button.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_video_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_video_button.Location = new System.Drawing.Point(340, 110);
            this.update_video_button.Name = "update_video_button";
            this.update_video_button.Size = new System.Drawing.Size(85, 46);
            this.update_video_button.TabIndex = 7;
            this.update_video_button.Text = "UPDATE";
            this.update_video_button.UseVisualStyleBackColor = false;
            this.update_video_button.Click += new System.EventHandler(this.update_video_button_Click);
            // 
            // add_video_button
            // 
            this.add_video_button.BackColor = System.Drawing.Color.Blue;
            this.add_video_button.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_video_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_video_button.Location = new System.Drawing.Point(253, 110);
            this.add_video_button.Name = "add_video_button";
            this.add_video_button.Size = new System.Drawing.Size(70, 46);
            this.add_video_button.TabIndex = 6;
            this.add_video_button.Text = "ADD";
            this.add_video_button.UseVisualStyleBackColor = false;
            this.add_video_button.Click += new System.EventHandler(this.add_video_button_Click);
            // 
            // genre_textBox
            // 
            this.genre_textBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_textBox.Location = new System.Drawing.Point(537, 76);
            this.genre_textBox.Name = "genre_textBox";
            this.genre_textBox.Size = new System.Drawing.Size(124, 32);
            this.genre_textBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Genre";
            // 
            // plot_textBox
            // 
            this.plot_textBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plot_textBox.Location = new System.Drawing.Point(323, 76);
            this.plot_textBox.Name = "plot_textBox";
            this.plot_textBox.Size = new System.Drawing.Size(127, 32);
            this.plot_textBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(229, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "VD Plot";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "VD Copies";
            // 
            // video_copy
            // 
            this.video_copy.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_copy.Location = new System.Drawing.Point(97, 76);
            this.video_copy.Name = "video_copy";
            this.video_copy.Size = new System.Drawing.Size(126, 32);
            this.video_copy.TabIndex = 11;
            // 
            // year_textBox
            // 
            this.year_textBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_textBox.Location = new System.Drawing.Point(546, 27);
            this.year_textBox.Name = "year_textBox";
            this.year_textBox.Size = new System.Drawing.Size(104, 32);
            this.year_textBox.TabIndex = 10;
            this.year_textBox.TextChanged += new System.EventHandler(this.year_textBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(466, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "VM year";
            // 
            // video_Ratting_TextBox
            // 
            this.video_Ratting_TextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_Ratting_TextBox.Location = new System.Drawing.Point(323, 29);
            this.video_Ratting_TextBox.Name = "video_Ratting_TextBox";
            this.video_Ratting_TextBox.Size = new System.Drawing.Size(127, 32);
            this.video_Ratting_TextBox.TabIndex = 3;
            this.video_Ratting_TextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "VD Rating";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "VD Name";
            // 
            // video_name_textBox
            // 
            this.video_name_textBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_name_textBox.Location = new System.Drawing.Point(97, 29);
            this.video_name_textBox.Name = "video_name_textBox";
            this.video_name_textBox.Size = new System.Drawing.Size(126, 32);
            this.video_name_textBox.TabIndex = 0;
            // 
            // customer_group
            // 
            this.customer_group.Controls.Add(this.btnCustomerView);
            this.customer_group.Controls.Add(this.del_customer_button);
            this.customer_group.Controls.Add(this.update_button);
            this.customer_group.Controls.Add(this.add_customer_button);
            this.customer_group.Controls.Add(this.customer_contact_textbox);
            this.customer_group.Controls.Add(this.label3);
            this.customer_group.Controls.Add(this.C_Address_textBox);
            this.customer_group.Controls.Add(this.label2);
            this.customer_group.Controls.Add(this.label1);
            this.customer_group.Controls.Add(this.customerName_textBox);
            this.customer_group.Location = new System.Drawing.Point(31, 568);
            this.customer_group.Name = "customer_group";
            this.customer_group.Size = new System.Drawing.Size(857, 112);
            this.customer_group.TabIndex = 40;
            this.customer_group.TabStop = false;
            this.customer_group.Text = "Enter Customer Details";
            this.customer_group.Visible = false;
            // 
            // btnCustomerView
            // 
            this.btnCustomerView.BackColor = System.Drawing.Color.Blue;
            this.btnCustomerView.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomerView.Location = new System.Drawing.Point(589, 63);
            this.btnCustomerView.Name = "btnCustomerView";
            this.btnCustomerView.Size = new System.Drawing.Size(102, 40);
            this.btnCustomerView.TabIndex = 9;
            this.btnCustomerView.Text = "View";
            this.btnCustomerView.UseVisualStyleBackColor = false;
            this.btnCustomerView.Click += new System.EventHandler(this.btnCustomerView_Click);
            // 
            // del_customer_button
            // 
            this.del_customer_button.BackColor = System.Drawing.Color.Blue;
            this.del_customer_button.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_customer_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.del_customer_button.Location = new System.Drawing.Point(445, 64);
            this.del_customer_button.Name = "del_customer_button";
            this.del_customer_button.Size = new System.Drawing.Size(102, 40);
            this.del_customer_button.TabIndex = 8;
            this.del_customer_button.Text = "DELETE";
            this.del_customer_button.UseVisualStyleBackColor = false;
            this.del_customer_button.Click += new System.EventHandler(this.del_customer_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Blue;
            this.update_button.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_button.Location = new System.Drawing.Point(323, 64);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(102, 40);
            this.update_button.TabIndex = 7;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // add_customer_button
            // 
            this.add_customer_button.BackColor = System.Drawing.Color.Blue;
            this.add_customer_button.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_customer_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_customer_button.Location = new System.Drawing.Point(201, 64);
            this.add_customer_button.Name = "add_customer_button";
            this.add_customer_button.Size = new System.Drawing.Size(103, 40);
            this.add_customer_button.TabIndex = 6;
            this.add_customer_button.Text = "ADD";
            this.add_customer_button.UseVisualStyleBackColor = false;
            this.add_customer_button.Click += new System.EventHandler(this.add_customer_button_Click);
            // 
            // customer_contact_textbox
            // 
            this.customer_contact_textbox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_contact_textbox.Location = new System.Drawing.Point(714, 31);
            this.customer_contact_textbox.Name = "customer_contact_textbox";
            this.customer_contact_textbox.Size = new System.Drawing.Size(143, 32);
            this.customer_contact_textbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(572, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Contact";
            // 
            // C_Address_textBox
            // 
            this.C_Address_textBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Address_textBox.Location = new System.Drawing.Point(423, 30);
            this.C_Address_textBox.Name = "C_Address_textBox";
            this.C_Address_textBox.Size = new System.Drawing.Size(143, 32);
            this.C_Address_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custmer Name";
            // 
            // customerName_textBox
            // 
            this.customerName_textBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName_textBox.Location = new System.Drawing.Point(133, 29);
            this.customerName_textBox.Name = "customerName_textBox";
            this.customerName_textBox.Size = new System.Drawing.Size(143, 32);
            this.customerName_textBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.customer_group);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.best_customer_btn);
            this.Controls.Add(this.best_video_butn);
            this.Controls.Add(this.rental_stored_button);
            this.Controls.Add(this.customers_Stored_button);
            this.Controls.Add(this.btn_videos);
            this.Controls.Add(this.data_show_grid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data_show_grid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.customer_group.ResumeLayout(false);
            this.customer_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_show_grid;
        private System.Windows.Forms.Button btn_videos;
        private System.Windows.Forms.Button customers_Stored_button;
        private System.Windows.Forms.Button rental_stored_button;
        private System.Windows.Forms.Button best_video_butn;
        private System.Windows.Forms.Button best_customer_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker return_date_picker;
        private System.Windows.Forms.DateTimePicker issue_date_picker;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button DELETE_movie_buton;
        private System.Windows.Forms.Button return_movie_buton;
        private System.Windows.Forms.Button issue_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox video_id_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox customer_id_textbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cost_text_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button delete_button_videos;
        private System.Windows.Forms.Button update_video_button;
        private System.Windows.Forms.Button add_video_button;
        private System.Windows.Forms.TextBox genre_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox plot_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox video_copy;
        private System.Windows.Forms.TextBox year_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox video_Ratting_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox video_name_textBox;
        private System.Windows.Forms.GroupBox customer_group;
        private System.Windows.Forms.Button del_customer_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button add_customer_button;
        private System.Windows.Forms.TextBox customer_contact_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox C_Address_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerName_textBox;
        private System.Windows.Forms.Button btnRetnalView;
        private System.Windows.Forms.Button btnVideoView;
        private System.Windows.Forms.Button btnCustomerView;
    }
}

