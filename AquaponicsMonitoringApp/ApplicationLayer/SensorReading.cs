using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaponicsMonitoringApp.ApplicationLayer
{
    /// <summary>
    /// This class is used to create an object that represents a sensor reading received from the sensors.
    /// </summary>
    public class SensorReading
    {
        private DateTime time;
        private DateTime date;
        private double readingVal;
        private int sensorId;


        /// <summary>
        /// Creates an Instance of this class.
        /// </summary>
        /// <param name="time">Defines the exact time at which the reading was taken.</param>
        /// <param name="date">Defines the date at which the reading was taken.</param>
        /// <param name="readingVal">represents the value received from the sensor.</param>
        /// <param name="sensorId">Uniquely identifies the sensor in the database.</param>
        public SensorReading(DateTime time, DateTime date, double readingVal, int sensorId)
        {
            this.Date = date;
            this.Time = time;
            this.ReadingVal = readingVal;
            this.SensorId = sensorId;
        }

        public SensorReading()
        {
        }

        public int SensorId
        {
            get { return sensorId; }
            set { sensorId = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


        public double ReadingVal
        {
            get { return readingVal; }
            set { readingVal = value; }
        }


        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            SensorReading reading = obj as SensorReading;
            if ((object)reading == null)
            {
                return false;
            }
            return ((this.Date == reading.Date) && (this.Time == reading.Time) && (this.ReadingVal == reading.ReadingVal) && (this.SensorId == reading.SensorId));
        }

        public override int GetHashCode()
        {
            return this.Time.GetHashCode() ^ this.Date.GetHashCode() ^ this.ReadingVal.GetHashCode() ^ this.SensorId.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void newReading()
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            dh.insertSensorReading(this);
        }
    }
}
