using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SQLiteAsyncConnection database;
            string db;

            db = DependencyService.Get<ISQLite>().GetLocalFilePath("TESHDB.db");
            database = new SQLiteAsyncConnection(db);
            database.CreateTableAsync<TESHDatos>().Wait();

            var elemento = new TESHDatos {
            Id = "13090351",
            Dato1 = "Lorena",
            Dato2 = "GarciaHernandez",
            Dato3 = "Sana Francisco",
            Dato4 = "5548566929",
            Dato5 = "ISC",
            Dato6 = "Noveno",
            Dato7 = "lorenatesh@hotmail.com",
            Dato8 = "GarciaLorena"
        };
            database.InsertAsync(elemento);


        }
    }
}
