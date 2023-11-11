using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1._4.Modelos
{
    public  class ImagenModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string RutaImagen { get; set; }
        public string Nombre { get; set; }
    }

    public static class AppEnvironment
    {
        public static string ImagenesPath => System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Imagenes");
        public static SQLiteConnection Database => new SQLiteConnection(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db3"));

        static AppEnvironment()
        {
            Database.CreateTable<ImagenModel>();
        }
    }
}
