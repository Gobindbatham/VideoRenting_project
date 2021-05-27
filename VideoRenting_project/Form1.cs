using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRenting_project
{
    public partial class Form1 : Form
    {
        
        DBControls controls = new DBControls();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void reset()
        {
            
            txtName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            cus_email.Text = "";

            CustomerID.Text = "";

            txtTitle.Text = "";
            txtRatting.Text = "";
            txtYear.Text = "";
            txtCopies.Text = "";
            txtCost.Text = "";
            txtGenre.Text = "";
            videoID.Text = "";
        }
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            //here i hve cll the method to insert the code of the student 
            if (controls.customerRegister(txtName.Text, txtAddress.Text, txtContact.Text, cus_email.Text) == 0)
            {
                MessageBox.Show("You need to fill the details");
            }
            else {
                MessageBox.Show("customer is registered in the portal ");
                reset();
            }
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (controls.customerEdit(CustomerID.Text,txtName.Text, txtAddress.Text, txtContact.Text, cus_email.Text) == 0)
            {
                MessageBox.Show("You need to select the details");
            }
            else
            {
                MessageBox.Show("customer is Modified in the portal ");
                reset();
            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (controls.customerRemove(CustomerID.Text) == 0)
            {
                MessageBox.Show("You need to select the details");
            }
            else
            {
                MessageBox.Show("customer is removed in the portal ");
                reset();
            }
        }

        private void videoAdd_Click(object sender, EventArgs e)
        {
            if (controls.movieRegister(txtTitle.Text,txtRatting.Text,txtYear.Text,txtCost.Text,txtCopies.Text,txtGenre.Text) == 0)
            {
                MessageBox.Show("You need to select the details");
            }
            else
            {
                MessageBox.Show("Video is registered in the portal ");
                reset();
            }
        }

        private void VideoUpdate_Click(object sender, EventArgs e)
        {
            if (controls.movieEdit(videoID.Text,txtTitle.Text, txtRatting.Text, txtYear.Text, txtCost.Text, txtCopies.Text, txtGenre.Text) == 0)
            {
                MessageBox.Show("You need to select the details");
            }
            else
            {
                MessageBox.Show("Video is Updated in the portal ");
                reset();
            }
        }

        private void videoDelete_Click(object sender, EventArgs e)
        {
            if (controls.movieRemove(videoID.Text) == 0)
            {
                MessageBox.Show("You need to select the details");
            }
            else
            {
                MessageBox.Show("Video is removed in the portal ");
                reset();
            }

        }


        private void issueVideo_Click(object sender, EventArgs e)
        {
            if (controls.booking(CustomerID.Text,videoID.Text,BookingDate.Text) == 0)
            {
                MessageBox.Show("You need to select the details");
            }
            else
            {
                MessageBox.Show("Video is Booked by the registered customer ");
                reset();
            }
        }

        private void deleteIsuuedVideos_Click(object sender, EventArgs e)
        {
            if (controls.bookingRemove(BookingID.Text) == 0)
            {
                MessageBox.Show("You need to select the details");
            }
            else
            {
                MessageBox.Show("Booked video entry is removed  ");
                reset();
            }
        }

        private void returnVideo_Click(object sender, EventArgs e)
        {
            if (controls.bookingReturn(BookingID.Text,CustomerID.Text, videoID.Text, BookingDate.Text,ReturnDate.Text) == 0)
            {
                MessageBox.Show("You need to select the details");
            }
            else
            {
                MessageBox.Show("Video is returned by the registered customer and the cost is " + controls.bookingReturn(BookingID.Text, CustomerID.Text, videoID.Text, BookingDate.Text, ReturnDate.Text));
                reset();
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            try {
                if (controls.generateCost(txtYear.Text)>0) {
                    txtCost.Text = "" + controls.generateCost(txtYear.Text);
                }
            } catch (Exception ex) { 
            
            }
        }

        private void rbRent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRent.Checked==true) {
                DataTable tbl = new DataTable();
                tbl = controls.CmdRecord("select * from Booking");
                Dtbse.DataSource = tbl;
            }
        }

        private void rbVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVideo.Checked == true)
            {
                DataTable tbl = new DataTable();
                tbl = controls.CmdRecord("select * from Video");
                Dtbse.DataSource = tbl;
            }
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomer.Checked == true)
            {
                DataTable tbl = new DataTable();
                tbl = controls.CmdRecord("select * from Customer");
                Dtbse.DataSource = tbl;
            }
        }

        private void Dtbse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbRent.Checked==true) {
                BookingID.Text = Dtbse.CurrentRow.Cells[0].Value.ToString();
                CustomerID.Text = Dtbse.CurrentRow.Cells[1].Value.ToString();
                videoID.Text = Dtbse.CurrentRow.Cells[2].Value.ToString();
                BookingDate.Text = Dtbse.CurrentRow.Cells[3].Value.ToString();

            }
            if (rbCustomer.Checked==true) { 
              CustomerID.Text = Dtbse.CurrentRow.Cells[0].Value.ToString();
              txtName.Text = Dtbse.CurrentRow.Cells[1].Value.ToString();
              txtAddress.Text = Dtbse.CurrentRow.Cells[2].Value.ToString();
              txtContact.Text = Dtbse.CurrentRow.Cells[3].Value.ToString();
              cus_email.Text = Dtbse.CurrentRow.Cells[4].Value.ToString();
            }
            if (rbVideo.Checked==true) { 
            videoID.Text = Dtbse.CurrentRow.Cells[0].Value.ToString();
                txtTitle.Text = Dtbse.CurrentRow.Cells[1].Value.ToString();
                txtRatting.Text = Dtbse.CurrentRow.Cells[2].Value.ToString();
                txtYear.Text = Dtbse.CurrentRow.Cells[3].Value.ToString();
                txtCost.Text = Dtbse.CurrentRow.Cells[4].Value.ToString();
                txtCopies.Text = Dtbse.CurrentRow.Cells[5].Value.ToString();
                txtGenre.Text = Dtbse.CurrentRow.Cells[6].Value.ToString();
            }

            rbRent.Checked = false;
            rbCustomer.Checked = false;
            rbVideo.Checked = false;
        }

        private void btnBestVideo_Click(object sender, EventArgs e)
        {
            DataTable tblVideo = new DataTable();


            tblVideo = controls.CmdRecord("select * from Video");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblVideo.Rows.Count; x++)
            {
                DataTable tblBooking = new DataTable();
                tblBooking = controls.CmdRecord("select * from Booking where VideoID='" + tblVideo.Rows[x]["VideoID"].ToString() + "'");

                if (tblBooking.Rows.Count > cunt)
                {
                    Title = tblVideo.Rows[x]["Name"].ToString();
                    cunt = tblBooking.Rows.Count;
                }

            }

            MessageBox.Show("Top most Video Name is " + Title);


        }

        private void btnBestCustomer_Click(object sender, EventArgs e)
        {
            DataTable tblCustomer = new DataTable();


            tblCustomer = controls.CmdRecord("select * from Customer");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblCustomer.Rows.Count; x++)
            {
                DataTable tblBooking = new DataTable();
                tblBooking = controls.CmdRecord("select * from Booking where CustomerID='" + tblCustomer.Rows[x]["CustomerID"].ToString() + "'");

                if (tblBooking.Rows.Count > cunt)
                {
                    Title = tblCustomer.Rows[x]["Name"].ToString();
                    cunt = tblBooking.Rows.Count;
                }

            }

            MessageBox.Show("Top most Customer Name is " + Title);
        }

        private void btnRentalPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
