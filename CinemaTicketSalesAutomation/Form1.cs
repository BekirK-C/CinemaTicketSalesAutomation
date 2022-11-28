using CinemaTicketSalesAutomation.Helpers;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Movie> movies;
        DateTime currentDate = DateTime.Now;
        DateTime useDate;
        Form2 form2;
        private void Form1_Load(object sender, EventArgs e)
        {
            useDate = currentDate;
            lblDate.Text= useDate.ToShortDateString();
            movies = Helper.CreateMovies();
            ListControls();
            form2 = new Form2(movies, this);
        }

        private void ListControls()
        {
            Size pictureSize = new Size(300, 100);
            Size buttonSize = new Size(90, 40);
            int x = 50, y = 100, xIncrement = 400, yIncrement = 300;
            for (int i = 0; i < movies.Count; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(x, y);
                pictureBox.Size = pictureSize;
                pictureBox.Image = Image.FromFile(movies[i].picturePath);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pictureBox);

                int buttonX = x, buttonY = pictureBox.Bottom + 10;
                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    button.Text = movies[i].sessions[j].time;
                    button.Location= new Point(buttonX, buttonY);
                    button.Size = buttonSize;
                    button.Tag = i;
                    button.Click += new EventHandler(button_Click); 
                    this.Controls.Add(button);
                    buttonX += 100;
                }
                if (x + xIncrement + pictureBox.Width < 1200)
                {
                    x += xIncrement;
                }
                else
                {
                    x = 50; 
                    y += yIncrement;
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int movieIndex = Convert.ToInt32(button.Tag);
            string sessionTime = button.Text;
            string sessionDate = lblDate.Text;
            if (DateTime.Parse($"{sessionDate} {sessionTime}") < DateTime.Now)
            {
                MessageBox.Show("Seçilen Seansı kaçırdınız.");
                return;
            }
            this.Hide();
            form2.Show();
            form2.ListDetail(movieIndex, sessionTime, sessionDate);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            useDate = useDate.AddDays(1);
            lblDate.Text = useDate.ToShortDateString();
            btnPrevious.Enabled = true;
            if (currentDate.AddDays(2) == useDate)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            useDate = useDate.AddDays(-1);
            lblDate.Text = useDate.ToShortDateString();
            btnNext.Enabled = true;
            if (currentDate == useDate)
            {
                btnPrevious.Enabled = false;
            }
        }
    }
}
