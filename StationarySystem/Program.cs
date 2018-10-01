﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationarySystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private static User currentUser = null;
        public static User getCurrentUser()
        {
            if (currentUser == null)
            {
                currentUser = new User();
            }
            return currentUser;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
