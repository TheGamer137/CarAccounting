using System;
using System.Configuration;
using System.Windows.Forms;
using CarAccounting.Presenters;
using CarAccounting.Views;
using CarAccounting.Views.Interfaces;

namespace CarAccounting
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view, connectionString);
            Application.Run((Form) view);
        }
    }
}
