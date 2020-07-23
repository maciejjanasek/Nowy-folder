﻿using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CUESYSv._01
{
    public class dbConn
    {

        ///// DB CONFIG START //////////////////////////////////////////////////////
        public string varConfigServer { get; set; }
        public string varConfigDatabase { get; set; }
        public string varConfigUser { get; set; }
        public string varConfigPass { get; set; }

        private string connString;
        public MySqlConnection conn;
        public MySqlDataAdapter mySQLda;


        ///// DB CONFIG END ////////////////////////////////////////////////////////



        public void connect()
        {//Connect to database (insecure, not using SSL or stored procedures)
            connString = "SERVER=" + varConfigServer + ";" +
                "DATABASE=" + varConfigDatabase + ";" +
                "UID=" + varConfigUser + ";" +
                "PASSWORD=" + varConfigPass + ";" +
                "SslMode=none;";
            conn = new MySqlConnection(connString);
        }
        public bool connOpen()
        {
            try { conn.Open(); return true; }
            catch (MySqlException err)
            {//Connection error handling control statement
                switch (err.Number)
                {
                    case 0:
                        MessageBox.Show("Server connection failure");
                        break;
                    case 1045:
                        MessageBox.Show("User/Password Error");
                        break;
                    default:
                        MessageBox.Show(err.Message);
                        break;
                }
                return false;
            }
        }
        public bool connClose()
        {//Connection close with error handling
            try { conn.Close(); return true; }
            catch (MySqlException err) { MessageBox.Show("Error: " + err.Message); return false; }
        }
        public DataSet qry(string sql)
        {//Run sql qry in argument and return dataset
            mySQLda = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            mySQLda.Fill(ds);
            connClose();
            return ds;
        }

        public void InsertCustomer(string custNationality, string custContact, string custEmail, string custTelephone, string custAddress1, string custAddress2, string custTownCity, string custPostcode)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblcustomer` (`custContact`, `custEmail`, `custTelephone`, `custAddress1`, `custAddress2`, `custTownCity`, `custPostcode`, `custNationality`) VALUES (@custContact, @custEmail, @custTelephone, @custAddress1, @custAddress2, @custTownCity, @custPostcode, @custNationality);";
            comm.Parameters.AddWithValue("@custContact", custContact);
            comm.Parameters.AddWithValue("@custEmail", custEmail);
            comm.Parameters.AddWithValue("@custTelephone", custTelephone);
            comm.Parameters.AddWithValue("@custAddress1", custAddress1);
            comm.Parameters.AddWithValue("@custAddress2", custAddress2);
            comm.Parameters.AddWithValue("@custTownCity", custTownCity);
            comm.Parameters.AddWithValue("@custPostcode", custPostcode);
            comm.Parameters.AddWithValue("@custNationality", custNationality);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void UpdateCustomer(string custID, string custNationality, string custContact, string custEmail, string custTelephone, string custAddress1, string custAddress2, string custtownCity, string custpostcode)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblcustomer` SET `custNationality`=@custNationality,`custContact`=@custContact,`custEmail`=@custEmail, `custTelephone`=@custTelephone, `custAddress1`=@custAddress1, `custAddress2`=@custAddress2, `custtownCity`=@custtownCity, `custpostcode`=@custpostcode WHERE `CustID` = @CustID";
            comm.Parameters.AddWithValue("@custNationality", custNationality);
            comm.Parameters.AddWithValue("@custContact", custContact);
            comm.Parameters.AddWithValue("@custEmail", custEmail);
            comm.Parameters.AddWithValue("@custTelephone", custTelephone);
            comm.Parameters.AddWithValue("@custAddress1", custAddress1);
            comm.Parameters.AddWithValue("@custAddress2", custAddress2);
            comm.Parameters.AddWithValue("@custtownCity", custtownCity);
            comm.Parameters.AddWithValue("@custpostcode", custpostcode);
            comm.Parameters.AddWithValue("@custID", custID);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void DeleteCustomer(string custID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblcustomer` WHERE `tblcustomer`.`custID` = @custID";
            comm.Parameters.AddWithValue("@custID", custID);
            comm.ExecuteNonQuery();
            connClose();
        }
        public void InsertBooking(string custContact, string flightNumber, string departure, string departureDate, string departureTime, string arrival, string arrivalDate, string arrivalTime, string bookingRoom, string bookingCostAdult,string bookingCostChild, string bookingCostInfant, string bookingPaid)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblbookings` (`custContact`, `flightNumber`, `departure`, `departureDate`, `departureTime`, `arrival`, `arrivalDate`, `arrivalTime`, `bookingRoom`, `bookingCostAdult`, `bookingCostChild`, `bookingCostInfant`, `bookingPaid`) " +
                               "VALUES (@custContact, @flightNumber, @departure, @departureDate, @departureTime, @arrival, @arrivalDate, @arrivalTime, @bookingRoom, @bookingCostAdult, @bookingCostChild, @bookingCostInfant, @bookingPaid);";

            comm.Parameters.AddWithValue("@custContact", custContact);
            comm.Parameters.AddWithValue("@flightNumber", flightNumber);
            comm.Parameters.AddWithValue("@departure", departure);
            comm.Parameters.AddWithValue("@departureDate", departureDate);
            comm.Parameters.AddWithValue("@departureTime", departureTime);
            comm.Parameters.AddWithValue("@arrival", arrival);
            comm.Parameters.AddWithValue("@arrivalDate", arrivalDate);
            comm.Parameters.AddWithValue("@arrivalTime", arrivalTime);
            comm.Parameters.AddWithValue("@bookingRoom", bookingRoom);
            comm.Parameters.AddWithValue("@bookingCostAdult", bookingCostAdult);
            comm.Parameters.AddWithValue("@bookingCostChild", bookingCostChild);
            comm.Parameters.AddWithValue("@bookingCostInfant", bookingCostInfant);
            comm.Parameters.AddWithValue("@bookingPaid", bookingPaid);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void UpdateBooking(string id, string custContact, string flightNumber, string departure, string departureDate, string departureTime, string arrival, string arrivalDate, string arrivalTime, string bookingRoom, string bookingCostAdult, string bookingCostChild, string bookingCostInfant, string bookingPaid)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblbookings` SET `id`=@id, `custContact`=@custContact, `flightNumber`=@flightNumber, `departure`=@departure, `departureDate`=@departureDate, `departureTime`=@departureTime, `arrival`=@arrival, `arrivalDate`=@arrivalDate, `arrivalTime`=@arrivalTime, `bookingRoom`=@bookingRoom, `bookingCostAdult`=@bookingCostAdult, `bookingCostChild`=@bookingCostChild, `bookingCostInfant`=@bookingCostInfant, `bookingPaid`=@bookingPaid WHERE `id`=@id";
            comm.Parameters.AddWithValue("@id", id);
            comm.Parameters.AddWithValue("@custContact", custContact);
            comm.Parameters.AddWithValue("@flightNumber", flightNumber);
            comm.Parameters.AddWithValue("@departure", departure);
            comm.Parameters.AddWithValue("@departureDate", departureDate);
            comm.Parameters.AddWithValue("@departureTime", departureTime);
            comm.Parameters.AddWithValue("@arrival", arrival);
            comm.Parameters.AddWithValue("@arrivalDate", arrivalDate);
            comm.Parameters.AddWithValue("@arrivalTime", arrivalTime);
            comm.Parameters.AddWithValue("@bookingRoom", bookingRoom);
            comm.Parameters.AddWithValue("@bookingCostAdult", bookingCostAdult);
            comm.Parameters.AddWithValue("@bookingCostChild", bookingCostChild);
            comm.Parameters.AddWithValue("@bookingCostInfant", bookingCostInfant);
            comm.Parameters.AddWithValue("@bookingPaid", bookingPaid);
            comm.ExecuteNonQuery();
            connClose();
        }
        public void DeleteBooking(string id)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblbookings` WHERE `tblbookings`.`id` = @id";
            comm.Parameters.AddWithValue("@id", id);
            comm.ExecuteNonQuery();
            connClose();
        }


        public void SearchFlight(string departure, string arrival)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT * FROM `tblflights` WHERE `tblflights`.`departureTextBox` = @departure, `arrivalTextBox` = @arrival";
            comm.Parameters.AddWithValue("departure", departure);
            comm.Parameters.AddWithValue("arrival", arrival);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void InsertFlight(string flightNumber, string departure, string departureDate, string departureTime, string arrival, string arrivalDate, string arrivalTime)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblflights`(`flightNumber`, `departure`, `departureDate`, `departureTime`, `arrival`, `arrivalDate`, `arrivalTime`)" + "VALUES (@flightNumber, @departure, @departureDate, @departureTime, @arrival, @arrivalDate, @arrivalTime)";
            comm.Parameters.AddWithValue("@flightNumber", flightNumber); 
            comm.Parameters.AddWithValue("@departure", departure);
            comm.Parameters.AddWithValue("@departureDate", departureDate);
            comm.Parameters.AddWithValue("@departureTime", departureTime);
            comm.Parameters.AddWithValue("@arrival", arrival); 
            comm.Parameters.AddWithValue("@arrivalDate", arrivalDate);
            comm.Parameters.AddWithValue("@arrivalTime", arrivalTime);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void UpdateFlight(string flightNumber, string departure, string departureDate, string departureTime, string arrival, string arrivalDate, string arrivalTime)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblflights` SET `flightNumber`=@flightNumber, `departure`=@departure, `departureDate`=@departureDate, `departureTime`=@departureTime, `arrival`=@arrival, `arrivalDate`=@arrivalDate, `arrivalTime`=@arrivalTime";
            comm.Parameters.AddWithValue("@flightNumber", flightNumber);
            comm.Parameters.AddWithValue("@departure", departure);
            comm.Parameters.AddWithValue("@departureDate", departureDate);
            comm.Parameters.AddWithValue("@departureTime", departureTime);
            comm.Parameters.AddWithValue("@arrival", arrival);
            comm.Parameters.AddWithValue("@arrivalDate", arrivalDate);
            comm.Parameters.AddWithValue("@arrivalTime", arrivalTime);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void DeleteFlight(string flightNumber)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblflights` WHERE `tblflights`.`flightNumber` = @flightNumber";
            comm.Parameters.AddWithValue("@flightNumber", flightNumber);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}