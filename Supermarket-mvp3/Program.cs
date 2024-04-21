using Supermarket_mvp3._Repositories;
using Supermarket_mvp3.Models;
using Supermarket_mvp3.Views;
using Supermarket_mvp3.Properties;
using System.Configuration;
using Supermarket_mvp3.Presenters;


namespace Supermarket_mvp3;
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);

            Application.Run((Form)view);



        }
    }
}