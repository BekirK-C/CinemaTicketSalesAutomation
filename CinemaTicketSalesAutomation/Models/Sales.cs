using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Models
{
    public class Sales : BaseModel
    {
        public Sales()
        {
            creationDate = DateTime.Now.ToString();
        }
        public string creationDate { get; set; }
        public decimal totalPrice { get; set; }
        public int count { get; set; }
        public string sessionTime { get; set; }

        public override string ToString()
        {
            return $"{movieName} adli filmin {sessionTime} seansına {count} adet bilet kesilmiştir.\n" +
                $"Toplam Tutar = {totalPrice} TL | Satın alma tarihi = {creationDate}";
        }
    }
}
