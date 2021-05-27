using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRenting_project
{
    public class DBControls
    {
        SqlConnection conn;

        //write the connection sstring to assthe data form one for to the database 
        String conStr = "Data Source=DESKTOP-G2UGPMF\\SQLEXPRESS;Initial Catalog=VideoRentalNew;Integrated Security=True";

        //command are use to excute the command of isnert , delete , update
        SqlCommand cmd;

        //data reader is used to read thedata from the database table 
        SqlDataReader DReader;


        //method used to execute query which doent return any thing only modifit the database
        public void CmdQuery(String query)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public DataTable CmdRecord(String qry)
        {
            DataTable tbl = new DataTable();

            conn = new SqlConnection(conStr);

            conn.Open();

            cmd = new SqlCommand(qry, conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl;
        }

        public int customerRegister(String Nme,String address,String contct,String Email) {
            if (Nme.Equals("") && address.Equals("") && contct.Equals("") && Email.Equals(""))
            {
                return 0;
            }
            else {
                CmdQuery("insert into Customer(Name,address,contact,Email) values('"+Nme +"','"+ address+ "','"+contct+"','"+Email+"')");
                return 1;
            }
        }

        public int customerRemove(String C_ID)
        {
            if (C_ID.Equals(""))
            {
                return 0;
            }
            else
            {
                CmdQuery("delete from Customer where CustomerID="+Convert.ToInt32(C_ID)+"");
                return 1;
            }
        }

        public int customerEdit(String C_ID,String Nme, String address, String contct, String Email)
        {
            if (C_ID.Equals("") && Nme.Equals("") && address.Equals("") && contct.Equals("") && Email.Equals(""))
            {
                return 0;
            }
            else
            {
                CmdQuery("Update Customer set Name='" + Nme + "',address='" + address + "',contact='" + contct + "',Email='" + Email + "' where CustomerID=" + Convert.ToInt32(C_ID) + "");
                return 1;
            }
        }



        public int movieRegister(String Name,String Ratting,String Year,String Cost, String Copies, String Genre) {
            if (Name.Equals("") && Ratting.Equals("") && Year.Equals("") && Cost.Equals("") && Copies.Equals("") && Genre.Equals("")) {
                return 0;
            }
            else {
                CmdQuery("insert into Video(Name,Ratting,Year,Cost,Copies,Genre)values('"+Name+"','"+Ratting+"','"+Year+"','"+Cost+"','"+Copies+"','"+Genre+"')");
                return 1;
            }
        
        }

        public int movieRemove(String V_ID)
        {
            if (V_ID.Equals("") )
            {
                return 0;
            }
            else
            {
                CmdQuery("delete from Video where VideoID="+Convert.ToInt32(V_ID)+"");
                return 1;
            }

        }


        public int movieEdit(String V_ID,String Name, String Ratting, String Year, String Cost, String Copies, String Genre)
        {
            if (V_ID.Equals("") && Name.Equals("") && Ratting.Equals("") && Year.Equals("") && Cost.Equals("") && Copies.Equals("") && Genre.Equals(""))
            {
                return 0;
            }
            else
            {
                CmdQuery("Update Video set Name='" + Name + "',Ratting='" + Ratting + "',Year='" + Year + "',Cost='" + Cost + "',Copies='" + Copies + "',Genre='" + Genre + "'  where VideoID=" + Convert.ToInt32(V_ID) + "");
                return 1;
            }

        }


        public int generateCost(String Year) {
            int cst = 0;
            if (!Year.Equals(""))
            {
                try
                {

                    DateTime dateNow = DateTime.Now;

                    int Currentyear = dateNow.Year;

                    int diffYear = Currentyear - Convert.ToInt32(Year);

                    // MessageBox.Show(diff.ToString());
                    if (diffYear >= 5)
                    {
                        cst = 2;
                    }
                    if (diffYear >= 0 && diffYear < 5)
                    {
                        cst = 5;
                    }


                }
                catch (Exception ex)
                {

                }

                return cst;
            }
            else {

                return -1;
            }

        }


        public int getCopies(int V_ID)
        {
            DataTable tbl = new DataTable();
            tbl = CmdRecord("select * from Video where VideoID=" + V_ID + "");
            return Convert.ToInt32(tbl.Rows[0]["Copies"].ToString());
        }
        public int getBooking(int V_ID)
        {
            DataTable tbl = new DataTable();
            tbl = CmdRecord("select * from Booking where VideoID='" + V_ID.ToString() + "' and ReturnDate='1'");
            return Convert.ToInt32(tbl.Rows.Count.ToString());
        }

        public int getCustomerBooking(int C_ID)
        {
            DataTable tbl = new DataTable();
            tbl = CmdRecord("select * from Booking where CustomerID='" + C_ID.ToString() + "' and ReturnDate='1'");
            return Convert.ToInt32(tbl.Rows.Count.ToString());
        }



        public int booking(String C_ID,String V_ID, String BookingDate) {
            if (C_ID.Equals("") && V_ID.Equals("") && BookingDate.Equals(""))
            {
                return 0;
            }
            else {
                if (getCopies(Convert.ToInt32(V_ID)) > getBooking(Convert.ToInt32(V_ID)))
                {
                    if (getCustomerBooking(Convert.ToInt32(C_ID)) < 2)
                    {
                        CmdQuery("insert into Booking(CustomerID,VideoID,BookingDate,ReturnDate)values('" + C_ID + "','" + V_ID + "','" + BookingDate + "','1')");
                        return 1;
                    }
                    else {
                        return 0;
                    }

                }
                else {
                    return 0;
                }
                
            }
        }


        public int getCost(int V_ID)
        {
            DataTable tbl = new DataTable();
            tbl = CmdRecord("select * from Video where VideoID=" + V_ID + "");
            return Convert.ToInt32(tbl.Rows[0]["Cost"].ToString());
        }


        public int bookingReturn(String B_ID,String C_ID, String V_ID, String BookingDate,String returnDate)
        {
            if (B_ID.Equals("") && C_ID.Equals("") && V_ID.Equals("") && BookingDate.Equals(""))
            {
                return 0;
            }
            else
            {

                DateTime current_date = DateTime.Now;

                //convert the old date from string to Date fromat
                DateTime prev_date = Convert.ToDateTime(BookingDate);


                //get the difference in the days fromat
                String Daysdiff = (current_date - prev_date).TotalDays.ToString();


                // calculate the round off value 
                Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));


                int total = getCost(Convert.ToInt32(V_ID)) * Convert.ToInt32(DaysInterval);

                CmdQuery("Update Booking set CustomerID='" + C_ID + "',VideoID='" + V_ID + "',BookingDate='" + BookingDate + "',ReturnDate='"+returnDate+"' where BookingID="+Convert.ToInt32(B_ID)+"");

                return total;

            }
        }

        public int bookingRemove(String B_ID)
        {
            if (B_ID.Equals("") )
            {
                return 0;
            }
            else
            {
                CmdQuery("delete from  Booking  where BookingID=" + Convert.ToInt32(B_ID) + "");
                return 1;
            }
        }
    }
}
