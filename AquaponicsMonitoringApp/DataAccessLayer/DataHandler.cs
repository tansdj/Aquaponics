using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using AquaponicsMonitoringApp.ApplicationLayer;

namespace AquaponicsMonitoringApp.DataAccessLayer
{
    /// <summary>
    /// Class Creator: Tanya
    /// This class is used to peform actions directly related to the database.
    /// Hides database actions from the front end.
    /// </summary>
    class DataHandler
    {
        private string connectionStringPrime;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;


        public DataHandler(string connectionStringParam = "default")
        {
            connectionStringPrime = ConfigurationManager.ConnectionStrings[connectionStringParam].ConnectionString;
        }

        public DataTable readDataFromDB(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection = new SqlConnection(connectionStringPrime);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(query, connection);
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception)
            {
                FileHandler file = new FileHandler("FileError.csv");
                List<string> error = new List<string>();
                error.Add("A Critical error occurred at:" + DateTime.UtcNow.ToShortDateString());
                file.WriteToTxt(error);
            }
            finally
            { connection.Close(); }
            return dataTable;
        }

        public List<Contact> getAllContacts()//Ek laat al die contacts return en nie net een nie, want dan kan mens dit gebruik om vir almal notifications te stuur.Of dan spesifiek.
        {
            List<Contact> contacts = new List<Contact>();
            DataTable data = readDataFromDB("SELECT * FROM [dbo].[tblContact]");

            foreach (DataRow item in data.Rows)
            {
                Contact contact = new Contact(Convert.ToInt32(item["SensorID"].ToString()), item["Email"].ToString(), Convert.ToInt32(item["ContactID"].ToString()));
                contacts.Add(contact);
            }
            return contacts;
        }

        public List<Notifications> getAllNotifications()
        {
            List<Notifications> notifications = new List<Notifications>();
            DataTable data = readDataFromDB("SELECT * FROM [dbo].[tblNotification]");

            foreach (DataRow item in data.Rows)
            {
                Notifications notify = new Notifications(Convert.ToInt32(item["SensorID"].ToString()), Convert.ToInt32(item["BottomValue"].ToString()), Convert.ToInt32(item["TopValue"].ToString()),Convert.ToInt32(item["NotifyID"].ToString()));
                notifications.Add(notify);
            }
            return notifications;
        }

        public List<Sensor> getAllSensors()
        {
            List<Sensor> sensors = new List<Sensor>();
            DataTable data = readDataFromDB("SELECT * FROM [dbo].[tblSensor]");

            foreach (DataRow item in data.Rows)
            {
                Sensor sensor = new Sensor(item["SensorName"].ToString(), item["SensorLocation"].ToString(), item["SensorType"].ToString(), Convert.ToInt32(item["SensorID"].ToString()));
                sensors.Add(sensor);
            }
            return sensors;
        }

        public List<string> getAllLocations()
        {
            List<string> locations = new List<string>();
            DataTable data = readDataFromDB("SELECT DISTINCT SensorLocation FROM tblSensor");
            foreach (DataRow item in data.Rows)
            {
                locations.Add(item["SensorLocation"].ToString());
            }
            return locations;
        }
        public List<SensorReading> getSensorReadings(Sensor sensor) //Vir hierdie een lees ons maar per sensor, anders is die List te groot en die table names te ingewikkeld
        {
            List<SensorReading> readings = new List<SensorReading>();
            try
            {
                string tableName = "tbl"+sensor.Location + "_" + sensor.Type + "_" + sensor.SensorID.ToString();
                DataTable data = readDataFromDB("SELECT * FROM " + tableName);
                int y = 0, m = 0, d = 0, hour = 0, min = 0, sec = 0;

                foreach (DataRow item in data.Rows)
                {
                    string[] dateSections = item["ReadingDate"].ToString().Split('-');
                    y = Convert.ToInt32(dateSections[0]);
                    m = Convert.ToInt32(dateSections[1]);
                    d = Convert.ToInt32(dateSections[2]);
                    DateTime date = new DateTime(y, m, d);

                    char[] delimiters = new char[] { ':', '.' };
                    string[] timeSections = item["ReadingTime"].ToString().Split(delimiters, StringSplitOptions.None);
                    hour = Convert.ToInt32(timeSections[0]);
                    min = Convert.ToInt32(timeSections[1]);
                    sec = Convert.ToInt32(timeSections[2]);
                    DateTime time = new DateTime(y, m, d, hour, min, sec); //Will display as time only, since time parameters can't be specified alone.

                    SensorReading reading = new SensorReading(time, date, Convert.ToDouble(item["ReadingVal"].ToString()), sensor.SensorID);
                    readings.Add(reading);
                }
            }
            catch (Exception)
            {
                FileHandler file = new FileHandler("FileError.csv");
                List<string> error = new List<string>();
                error.Add("A Critical error occurred at:" + DateTime.UtcNow.ToShortDateString());
                file.WriteToTxt(error);
            }

            return readings;
        }

        public List<User> getAllUsers()
        {
            List<User> users = new List<User>();
            DataTable data = readDataFromDB("SELECT * FROM [dbo].[tblUsers]");

            foreach (DataRow item in data.Rows)
            {
                User user = new User(item["Username"].ToString(), item["user_Password"].ToString(), item["user_Email"].ToString(), item["user_secQ"].ToString(), item["user_secA"].ToString(), Convert.ToInt32(item["UserID"].ToString()));
                users.Add(user);
            }
            return users;
        }

        public int getCurrentFrequency()
        {
            int freq = 1;
            DataTable data = readDataFromDB("SELECT TOP 1 Frequency FROM [dbo].[tblUpdateFrequency] ORDER BY FreqSetDate DESC");
            foreach (DataRow item in data.Rows)
            {
                freq = Convert.ToInt32(item["Frequency"].ToString());
            }
            return freq;
        }

        public List<FrequencySettings> getAllFrequencySettings()
        {
            int y = 0, m = 0, d = 0;
            List<FrequencySettings> freqs = new List<FrequencySettings>();
            DataTable data = readDataFromDB("SELECT * FROM [dbo].[tblUpdateFrequency]");
            foreach (DataRow item in data.Rows)
            {
                string[] dateSections = item["FreqSetDate"].ToString().Split('-');
                y = Convert.ToInt32(dateSections[0]);
                m = Convert.ToInt32(dateSections[1]);
                d = Convert.ToInt32(dateSections[2]);
                DateTime date = new DateTime(y, m, d);
                FrequencySettings fs = new FrequencySettings(date, Convert.ToInt32(item["Frequency"].ToString()));
                freqs.Add(fs);
            }
            return freqs;
        }

        public void insertSensor(Sensor sensor)
        {
            try
            {
                connection = new SqlConnection(connectionStringPrime);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(QueryBuilder.procNewSensor, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamNewSensorName, sensor.SensorName));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamNewSensorLoc, sensor.Location));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamNewSensorType, sensor.Type));
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                FileHandler file = new FileHandler("FileError.csv");
                List<string> error = new List<string>();
                error.Add("A Critical error occurred at:" + DateTime.UtcNow.ToShortDateString());
                file.WriteToTxt(error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void removeSensor(Sensor sensor)
        {
            try
            {
                connection = new SqlConnection(connectionStringPrime);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(QueryBuilder.procRemoveSensor, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamRemoveSensorId, sensor.SensorID));
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                FileHandler file = new FileHandler("FileError.csv");
                List<string> error = new List<string>();
                error.Add("A Critical error occurred at:" + DateTime.UtcNow.ToShortDateString());
                file.WriteToTxt(error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void insertUser(User user)
        {
            try
            {
                connection = new SqlConnection(connectionStringPrime);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(QueryBuilder.procInsertUser, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamInsertUserUsername, user.Username));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamInsertUserPassword, user.Password));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamInsertUserEmail, user.Email));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamInsertUserSecQ, user.SecurityQ));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamInsertUserSecA, user.SecurityA));
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                FileHandler file = new FileHandler("FileError.csv");
                List<string> error = new List<string>();
                error.Add("A Critical error occurred at:" + DateTime.UtcNow.ToShortDateString());
                file.WriteToTxt(error);
            }
            finally
            {
                connection.Close();
            }

        }

        public void updateUser(User user)
        {
            try
            {
                connection = new SqlConnection(connectionStringPrime);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(QueryBuilder.procUpdateUser, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamUpdateUserId, user.UserID));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamUpdateUserUsername, user.Username));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamUpdateUserPassword, user.Password));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamInsertUserEmail, user.Email));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamInsertUserSecQ, user.SecurityQ));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamInsertUserSecA, user.SecurityA));
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                FileHandler file = new FileHandler("FileError.csv");
                List<string> error = new List<string>();
                error.Add("A Critical error occurred at:" + DateTime.UtcNow.ToShortDateString());
                file.WriteToTxt(error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void newNotification(Notifications notify)
        {
            try
            {
                connection = new SqlConnection(connectionStringPrime);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(QueryBuilder.procNewNotification, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamNewNotificationSensorId, notify.SensorID));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamNewNotificationBottomVal, notify.BottomValue));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamNewNotificationTopVal, notify.TopValue));
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                FileHandler file = new FileHandler("FileError.csv");
                List<string> error = new List<string>();
                error.Add("A Critical error occurred at:" + DateTime.UtcNow.ToShortDateString());
                file.WriteToTxt(error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void updateNotification(Notifications notify)
        {
            try
            {
                connection = new SqlConnection(connectionStringPrime);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(QueryBuilder.procUpdateNotification, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamUpdateNotifcationSensorId, notify.SensorID));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamUpdateNotifcationBottomVal, notify.BottomValue));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamUpdateNotifcationTopVal, notify.TopValue));
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                FileHandler file = new FileHandler("FileError.csv");
                List<string> error = new List<string>();
                error.Add("A Critical error occurred at:" + DateTime.UtcNow.ToShortDateString());
                file.WriteToTxt(error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void newContact(Contact contact)
        {
            try
            {
                connection = new SqlConnection(connectionStringPrime);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(QueryBuilder.procNewContact, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamNewContactSensorId, contact.SensorID));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamNewContactEmail, contact.Email));
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                FileHandler file = new FileHandler("FileError.csv");
                List<string> error = new List<string>();
                error.Add("A Critical error occurred at:" + DateTime.UtcNow.ToShortDateString());
                file.WriteToTxt(error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void updateContact(Contact contact, string priorEmail)
        {
            try
            {
                connection = new SqlConnection(connectionStringPrime);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(QueryBuilder.procUpdateContact, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamUpdateContactSensorId, contact.SensorID));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamUpdateContactNewEmail, contact.Email));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamUpdateContactPriorEmail, priorEmail));
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                FileHandler file = new FileHandler("FileError.csv");
                List<string> error = new List<string>();
                error.Add("A Critical error occurred at:" + DateTime.UtcNow.ToShortDateString());
                file.WriteToTxt(error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void removeContact(Contact contact)
        {
            try
            {
                connection = new SqlConnection(connectionStringPrime);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(QueryBuilder.procRemoveContact, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamRemoveContactSensorId, contact.SensorID));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamRemoveContactEmail, contact.Email));
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                FileHandler file = new FileHandler("FileError.csv");
                List<string> error = new List<string>();
                error.Add("A Critical error occurred at:" + DateTime.UtcNow.ToShortDateString());
                file.WriteToTxt(error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void insertSensorReading(SensorReading reading)
        {
            string query = "", tableName = "";
            bool exist = true;
            DataHandler data = new DataHandler();

            DataTable dataTable = data.readDataFromDB("SELECT * FROM [dbo].[tblSensor]");

            foreach (DataRow item in dataTable.Rows)
            {
                if (item["SensorID"].ToString() == reading.SensorId.ToString())
                {
                    tableName = "tbl"+item["SensorLocation"].ToString() + "_" + item["SensorType"].ToString() + "_" + reading.SensorId.ToString();
                }
            }

            try
            {
                connection = new SqlConnection(connectionStringPrime);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                query = "SELECT * FROM " + tableName;
                command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                dataAdapter = new SqlDataAdapter(command);
                DataTable data1 = new DataTable();
                try
                {
                    dataAdapter.Fill(data1);
                }
                catch (Exception)
                {
                    exist = false;
                    query = "CREATE TABLE " + tableName + " (ReadingID INT IDENTITY PRIMARY KEY,ReadingTime TIME NOT NULL,ReadingDate DATE NOT NULL,ReadingVal FLOAT NOT NULL);";
                    command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                    query = "INSERT INTO " + tableName + " (ReadingTime,ReadingDate,ReadingVal) VALUES ('" + String.Format("{0:hh:mm:ss}", reading.Time) + ".0000','" + String.Format("{0:yyyy-MM-dd}", reading.Date) + "'," + reading.ReadingVal.ToString() + ");";
                    command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                if (exist == true)
                {
                    query = "INSERT INTO " + tableName + " (ReadingTime,ReadingDate,ReadingVal) VALUES ('" + String.Format("{0:hh:mm:ss}", reading.Time) + ".0000','" + String.Format("{0:yyyy-MM-dd}", reading.Date) + "'," + reading.ReadingVal.ToString() + ");";
                    command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                FileHandler file = new FileHandler("FileError.csv");
                List<string> error = new List<string>();
                error.Add("A Critical error occurred at:" + DateTime.UtcNow.ToShortDateString());
                file.WriteToTxt(error);
            }
        }

        public void insertFrequency(FrequencySettings fs)
        {
            try
            {
                connection = new SqlConnection(connectionStringPrime);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(QueryBuilder.procInsertFreq, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamInsertFreqDate, String.Format("{0:yyyy-MM-dd}",fs.FreqDate)));
                command.Parameters.Add(new SqlParameter(QueryBuilder.procParamInsertFreqValue, fs.Frequency));
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                FileHandler file = new FileHandler("FileError.csv");
                List<string> error = new List<string>();
                error.Add("A Critical error occurred at:" + DateTime.UtcNow.ToShortDateString());
                file.WriteToTxt(error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
