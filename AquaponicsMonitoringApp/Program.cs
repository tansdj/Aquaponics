﻿using AquaponicsMonitoringApp.ApplicationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AquaponicsMonitoringApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMainDashboard());

            User user = new User("user1", "pass", "tansdj@gmail.com", "Question", "Answer", 0);
        }
    }
}
