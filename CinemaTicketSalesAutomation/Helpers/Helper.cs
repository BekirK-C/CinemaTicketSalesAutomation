using CinemaTicketSalesAutomation.Enums;
using CinemaTicketSalesAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:\\Users\\Bekir\\Desktop\\C#\\17. CinemaTicketSalesAutomation\\CinemaTicketSalesAutomation\\Pictures\\.jpg";
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Yıldızlararası",
                    category = Category.bilim_kurgu,
                    minute = " 2 saat 49 dk",
                    price = 50,
                    picturePath = basePath + "yıldızlararası.jpg"
                },
                new Movie()
                {
                    movieName = "Nefesini Tut",
                    category = Category.gerilim,
                    minute = " 1 saat 28 dk",
                    price = 40,
                    picturePath = basePath + "nefesini tut.jpg"
                },
                new Movie()
                {
                    movieName = "3 Aptal",
                    category = Category.bilim_kurgu,
                    minute = " 2 saat 51 dk",
                    price = 60,
                    picturePath = basePath + "3 aptal.jpg"
                },
                new Movie()
                {
                    movieName = "Geleceğe Dönüş",
                    category = Category.komedi,
                    minute = "1 saat 56 dk",
                    price = 50,
                    picturePath = basePath + "Geleceğe Dönüş.jpg"
                },
                new Movie()
                {
                    movieName = "Jumanji",
                    category = Category.macera,
                    minute = " 1 saat 44 dk",
                    price = 50,
                    picturePath = basePath + "jumanji.jpg"
                },
                new Movie()
                {
                    movieName = "Warcraft",
                    category = Category.fantastk,
                    minute = " 2 saat 3 dk",
                    price = 40,
                    picturePath = basePath + "warcraft.jpg"
                },
            };
        }
    }
}
