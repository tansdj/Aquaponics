using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaponicsMonitoringApp.ApplicationLayer
{
    /// <summary>
    /// This class is used to work with the notification details per sensor, therefore determines
    /// when the listed contacts should be notified of changes within the system.
    /// </summary>
    public class Notifications
    {
        private int notifyID;
        private int sensorID;
        private int bottomValue;
        private int topValue;



        /// <summary>
        /// Creates an Instance of this class
        /// </summary>
        /// <param name="sensorID">An integer value used to identify the sensor in the database.</param>
        /// <param name="bottomValue">Defines the lower boundary of the critical range.</param>
        /// <param name="topValue">Defines the upper boundary of the critical range,</param>
        /// <param name="notifyID">An integer value that is used to identify this notification setting in the database.</param>
        public Notifications(int sensorID, int bottomValue, int topValue,int notifyID = 0)
        {
            this.NotifyID = notifyID;
            this.SensorID = sensorID;
            this.BottomValue = bottomValue;
            this.TopValue = topValue;
        }

        public Notifications()
        {
        }

        public int TopValue
        {
            get { return topValue; }
            set { topValue = value; }
        }


        public int BottomValue
        {
            get { return bottomValue; }
            set { bottomValue = value; }
        }


        public int SensorID
        {
            get { return sensorID; }
            set { sensorID = value; }
        }


        public int NotifyID
        {
            get { return notifyID; }
            set { notifyID = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Notifications notify = obj as Notifications;
            if ((object)notify == null)
            {
                return false;
            }
            return ((this.NotifyID == notify.NotifyID) && (this.SensorID == notify.SensorID) && (this.BottomValue == notify.BottomValue) && (this.TopValue == notify.TopValue));
        }

        public override int GetHashCode()
        {
            return this.NotifyID.GetHashCode() ^ this.SensorID.GetHashCode() ^ this.BottomValue.GetHashCode() ^ this.TopValue.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void insertNotification()
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            dh.newNotification(this);
        }

        public void updateNotifications()
        {
            DataAccessLayer.DataHandler dh = new DataAccessLayer.DataHandler();
            dh.updateNotification(this);
        }

    }
}
