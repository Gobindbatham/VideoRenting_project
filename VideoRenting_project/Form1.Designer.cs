
namespace VideoRenting_project
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
            this.label17 = new System.Windows.Forms.Label();
            this.cus_email = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.videoID = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.rbRent = new System.Windows.Forms.RadioButton();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.deleteIsuuedVideos = new System.Windows.Forms.Button();
            this.returnVideo = new System.Windows.Forms.Button();
            this.issueVideo = new System.Windows.Forms.Button();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.BookingDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBestCustomer = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnBestVideo = new System.Windows.Forms.Button();
            this.VideoUpdate = new System.Windows.Forms.Button();
            this.videoDelete = new System.Windows.Forms.Button();
            this.videoAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRatting = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.Dtbse = new System.Windows.Forms.DataGridView();
            this.BookingID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dtbse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(469, 430);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 19);
            this.label17.TabIndex = 117;
            this.label17.Text = "Email";
            // 
            // cus_email
            // 
            this.cus_email.BackColor = System.Drawing.SystemColors.MenuText;
            this.cus_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_email.ForeColor = System.Drawing.SystemColors.Window;
            this.cus_email.Location = new System.Drawing.Point(472, 453);
            this.cus_email.Name = "cus_email";
            this.cus_email.Size = new System.Drawing.Size(155, 24);
            this.cus_email.TabIndex = 116;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.RoyalBlue;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(111, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 25);
            this.label14.TabIndex = 113;
            this.label14.Text = "CRUD Videos";
            // 
            // videoID
            // 
            this.videoID.BackColor = System.Drawing.SystemColors.MenuText;
            this.videoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoID.ForeColor = System.Drawing.SystemColors.Window;
            this.videoID.Location = new System.Drawing.Point(784, 302);
            this.videoID.Name = "videoID";
            this.videoID.Size = new System.Drawing.Size(155, 24);
            this.videoID.TabIndex = 112;
            // 
            // CustomerID
            // 
            this.CustomerID.BackColor = System.Drawing.SystemColors.MenuText;
            this.CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.ForeColor = System.Drawing.SystemColors.Window;
            this.CustomerID.Location = new System.Drawing.Point(784, 339);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(155, 24);
            this.CustomerID.TabIndex = 111;
            // 
            // rbRent
            // 
            this.rbRent.AutoSize = true;
            this.rbRent.BackColor = System.Drawing.Color.RoyalBlue;
            this.rbRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRent.ForeColor = System.Drawing.Color.White;
            this.rbRent.Location = new System.Drawing.Point(786, 24);
            this.rbRent.Name = "rbRent";
            this.rbRent.Size = new System.Drawing.Size(212, 28);
            this.rbRent.TabIndex = 110;
            this.rbRent.TabStop = true;
            this.rbRent.Text = "VIDEOS ON RENTAL";
            this.rbRent.UseVisualStyleBackColor = false;
            this.rbRent.CheckedChanged += new System.EventHandler(this.rbRent_CheckedChanged);
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.BackColor = System.Drawing.Color.RoyalBlue;
            this.rbVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVideo.ForeColor = System.Drawing.Color.White;
            this.rbVideo.Location = new System.Drawing.Point(395, 24);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(162, 28);
            this.rbVideo.TabIndex = 109;
            this.rbVideo.TabStop = true;
            this.rbVideo.Text = "SHOW VIDEOS";
            this.rbVideo.UseVisualStyleBackColor = false;
            this.rbVideo.CheckedChanged += new System.EventHandler(this.rbVideo_CheckedChanged);
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.BackColor = System.Drawing.Color.RoyalBlue;
            this.rbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustomer.ForeColor = System.Drawing.Color.White;
            this.rbCustomer.Location = new System.Drawing.Point(563, 24);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(217, 28);
            this.rbCustomer.TabIndex = 108;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "ADDED CUSTOMERS";
            this.rbCustomer.UseVisualStyleBackColor = false;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.rbCustomer_CheckedChanged);
            // 
            // deleteIsuuedVideos
            // 
            this.deleteIsuuedVideos.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteIsuuedVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIsuuedVideos.ForeColor = System.Drawing.Color.White;
            this.deleteIsuuedVideos.Location = new System.Drawing.Point(784, 512);
            this.deleteIsuuedVideos.Name = "deleteIsuuedVideos";
            this.deleteIsuuedVideos.Size = new System.Drawing.Size(179, 30);
            this.deleteIsuuedVideos.TabIndex = 103;
            this.deleteIsuuedVideos.Text = "Delete";
            this.deleteIsuuedVideos.UseVisualStyleBackColor = false;
            this.deleteIsuuedVideos.Click += new System.EventHandler(this.deleteIsuuedVideos_Click);
            // 
            // returnVideo
            // 
            this.returnVideo.BackColor = System.Drawing.Color.RoyalBlue;
            this.returnVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnVideo.ForeColor = System.Drawing.Color.White;
            this.returnVideo.Location = new System.Drawing.Point(784, 476);
            this.returnVideo.Name = "returnVideo";
            this.returnVideo.Size = new System.Drawing.Size(179, 30);
            this.returnVideo.TabIndex = 102;
            this.returnVideo.Text = "Return";
            this.returnVideo.UseVisualStyleBackColor = false;
            this.returnVideo.Click += new System.EventHandler(this.returnVideo_Click);
            // 
            // issueVideo
            // 
            this.issueVideo.BackColor = System.Drawing.Color.RoyalBlue;
            this.issueVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueVideo.ForeColor = System.Drawing.Color.White;
            this.issueVideo.Location = new System.Drawing.Point(784, 440);
            this.issueVideo.Name = "issueVideo";
            this.issueVideo.Size = new System.Drawing.Size(179, 30);
            this.issueVideo.TabIndex = 101;
            this.issueVideo.Text = "Issue";
            this.issueVideo.UseVisualStyleBackColor = false;
            this.issueVideo.Click += new System.EventHandler(this.issueVideo_Click);
            // 
            // ReturnDate
            // 
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDate.Location = new System.Drawing.Point(803, 402);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(102, 20);
            this.ReturnDate.TabIndex = 100;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(693, 406);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 99;
            this.label13.Text = "Return Date";
            // 
            // BookingDate
            // 
            this.BookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookingDate.Location = new System.Drawing.Point(803, 368);
            this.BookingDate.Name = "BookingDate";
            this.BookingDate.Size = new System.Drawing.Size(102, 20);
            this.BookingDate.TabIndex = 98;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(693, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 97;
            this.label11.Text = "Booking Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(697, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 96;
            this.label12.Text = "Customer ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(698, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 95;
            this.label10.Text = "Video ID";
            // 
            // btnBestCustomer
            // 
            this.btnBestCustomer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBestCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestCustomer.ForeColor = System.Drawing.Color.White;
            this.btnBestCustomer.Location = new System.Drawing.Point(485, 561);
            this.btnBestCustomer.Name = "btnBestCustomer";
            this.btnBestCustomer.Size = new System.Drawing.Size(171, 30);
            this.btnBestCustomer.TabIndex = 94;
            this.btnBestCustomer.Text = "Best Customer";
            this.btnBestCustomer.UseVisualStyleBackColor = false;
            this.btnBestCustomer.Click += new System.EventHandler(this.btnBestCustomer_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerUpdate.ForeColor = System.Drawing.Color.White;
            this.btnCustomerUpdate.Location = new System.Drawing.Point(575, 489);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(171, 30);
            this.btnCustomerUpdate.TabIndex = 93;
            this.btnCustomerUpdate.Text = "Customer Update";
            this.btnCustomerUpdate.UseVisualStyleBackColor = false;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDelete.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDelete.Location = new System.Drawing.Point(485, 525);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(171, 30);
            this.btnCustomerDelete.TabIndex = 92;
            this.btnCustomerDelete.Text = "Customer Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = false;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerAdd.ForeColor = System.Drawing.Color.White;
            this.btnCustomerAdd.Location = new System.Drawing.Point(389, 489);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(171, 30);
            this.btnCustomerAdd.TabIndex = 89;
            this.btnCustomerAdd.Text = "Customer Add";
            this.btnCustomerAdd.UseVisualStyleBackColor = false;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 91;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 90;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 88;
            this.label1.Text = "Name";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.SystemColors.Window;
            this.txtContact.Location = new System.Drawing.Point(469, 407);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(155, 24);
            this.txtContact.TabIndex = 87;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Location = new System.Drawing.Point(469, 359);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(155, 24);
            this.txtAddress.TabIndex = 86;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(469, 314);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 24);
            this.txtName.TabIndex = 85;
            // 
            // btnBestVideo
            // 
            this.btnBestVideo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBestVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestVideo.ForeColor = System.Drawing.Color.White;
            this.btnBestVideo.Location = new System.Drawing.Point(115, 542);
            this.btnBestVideo.Name = "btnBestVideo";
            this.btnBestVideo.Size = new System.Drawing.Size(158, 36);
            this.btnBestVideo.TabIndex = 84;
            this.btnBestVideo.Text = "Best Video";
            this.btnBestVideo.UseVisualStyleBackColor = false;
            this.btnBestVideo.Click += new System.EventHandler(this.btnBestVideo_Click);
            // 
            // VideoUpdate
            // 
            this.VideoUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.VideoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoUpdate.ForeColor = System.Drawing.Color.White;
            this.VideoUpdate.Location = new System.Drawing.Point(196, 447);
            this.VideoUpdate.Name = "VideoUpdate";
            this.VideoUpdate.Size = new System.Drawing.Size(158, 36);
            this.VideoUpdate.TabIndex = 83;
            this.VideoUpdate.Text = "Video Update";
            this.VideoUpdate.UseVisualStyleBackColor = false;
            this.VideoUpdate.Click += new System.EventHandler(this.VideoUpdate_Click);
            // 
            // videoDelete
            // 
            this.videoDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.videoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoDelete.ForeColor = System.Drawing.Color.White;
            this.videoDelete.Location = new System.Drawing.Point(115, 489);
            this.videoDelete.Name = "videoDelete";
            this.videoDelete.Size = new System.Drawing.Size(158, 36);
            this.videoDelete.TabIndex = 82;
            this.videoDelete.Text = "Video Delete";
            this.videoDelete.UseVisualStyleBackColor = false;
            this.videoDelete.Click += new System.EventHandler(this.videoDelete_Click);
            // 
            // videoAdd
            // 
            this.videoAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.videoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoAdd.ForeColor = System.Drawing.Color.White;
            this.videoAdd.Location = new System.Drawing.Point(24, 447);
            this.videoAdd.Name = "videoAdd";
            this.videoAdd.Size = new System.Drawing.Size(158, 36);
            this.videoAdd.TabIndex = 73;
            this.videoAdd.Text = "Video Add";
            this.videoAdd.UseVisualStyleBackColor = false;
            this.videoAdd.Click += new System.EventHandler(this.videoAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(192, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 19);
            this.label9.TabIndex = 81;
            this.label9.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtGenre.Location = new System.Drawing.Point(195, 406);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(155, 24);
            this.txtGenre.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(192, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 79;
            this.label8.Text = "Copies";
            // 
            // txtCopies
            // 
            this.txtCopies.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopies.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCopies.Location = new System.Drawing.Point(195, 351);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(155, 24);
            this.txtCopies.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 77;
            this.label7.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCost.Enabled = false;
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCost.Location = new System.Drawing.Point(195, 302);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(155, 24);
            this.txtCost.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 75;
            this.label6.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.SystemColors.Window;
            this.txtYear.Location = new System.Drawing.Point(29, 406);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(155, 24);
            this.txtYear.TabIndex = 74;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 72;
            this.label5.Text = "Ratting";
            // 
            // txtRatting
            // 
            this.txtRatting.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtRatting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRatting.ForeColor = System.Drawing.SystemColors.Window;
            this.txtRatting.Location = new System.Drawing.Point(30, 351);
            this.txtRatting.Name = "txtRatting";
            this.txtRatting.Size = new System.Drawing.Size(155, 24);
            this.txtRatting.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 70;
            this.label4.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTitle.Location = new System.Drawing.Point(27, 302);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(155, 24);
            this.txtTitle.TabIndex = 69;
            // 
            // Dtbse
            // 
            this.Dtbse.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.Dtbse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtbse.Location = new System.Drawing.Point(44, 58);
            this.Dtbse.Name = "Dtbse";
            this.Dtbse.Size = new System.Drawing.Size(919, 182);
            this.Dtbse.TabIndex = 118;
            this.Dtbse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtbse_CellClick);
            // 
            // BookingID
            // 
            this.BookingID.AutoSize = true;
            this.BookingID.Location = new System.Drawing.Point(937, 317);
            this.BookingID.Name = "BookingID";
            this.BookingID.Size = new System.Drawing.Size(0, 13);
            this.BookingID.TabIndex = 119;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Location = new System.Drawing.Point(373, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 235);
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.Location = new System.Drawing.Point(677, 246);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 235);
            this.pictureBox2.TabIndex = 121;
            this.pictureBox2.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.RoyalBlue;
            this.label18.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(747, 246);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(190, 25);
            this.label18.TabIndex = 122;
            this.label18.Text = "Issue/ Return Videos";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.RoyalBlue;
            this.label19.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(464, 246);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(162, 25);
            this.label19.TabIndex = 123;
            this.label19.Text = "CRUD Customers";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.RoyalBlue;
            this.label15.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(1, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(377, 25);
            this.label15.TabIndex = 124;
            this.label15.Text = "Note: Click on Radio Button to View Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1010, 602);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BookingID);
            this.Controls.Add(this.Dtbse);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cus_email);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.videoID);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.rbRent);
            this.Controls.Add(this.rbVideo);
            this.Controls.Add(this.rbCustomer);
            this.Controls.Add(this.deleteIsuuedVideos);
            this.Controls.Add(this.returnVideo);
            this.Controls.Add(this.issueVideo);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BookingDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBestCustomer);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnBestVideo);
            this.Controls.Add(this.VideoUpdate);
            this.Controls.Add(this.videoDelete);
            this.Controls.Add(this.videoAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRatting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtbse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox cus_email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox videoID;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.RadioButton rbRent;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.Button deleteIsuuedVideos;
        private System.Windows.Forms.Button returnVideo;
        private System.Windows.Forms.Button issueVideo;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker BookingDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBestCustomer;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnBestVideo;
        private System.Windows.Forms.Button VideoUpdate;
        private System.Windows.Forms.Button videoDelete;
        private System.Windows.Forms.Button videoAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRatting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DataGridView Dtbse;
        private System.Windows.Forms.Label BookingID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
    }
}

