using CinemaTicketSalesAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicketSalesAutomation
{
    public partial class Form2 : Form
    {
        List<Movie> movies;
        Form form1;
        Movie selectedMovie;
        Session selectedSession;
        public Form2(List<Movie> _movies, Form  _form1)
        {
            InitializeComponent();
            movies= _movies;
            form1= _form1;
        }
        public void ListDetail(int movieIndex, string _time, string _date)
        {
            selectedMovie = movies[movieIndex];
            selectedSession = selectedMovie.sessions.Find(s => s.date == _date && s.time == _time);
            lblTime.Text = $"{_date} - {_time}";
            lblMinute.Text = selectedMovie.minute;
            lblPrice.Text = selectedMovie.price.ToString() + "TL";
            pbSelectedPicture.Image = Image.FromFile(selectedMovie.picturePath);
            lblCategory.Text = selectedMovie.category.ToString();
        }
    }
}
