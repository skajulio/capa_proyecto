using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Y2K.Models
{
    public class ReservationVM
    {
        public Reservation Reservation { get; set; }
        public List<City> City { get; set; }

        public ReservationVM()
        {
            using (var db = new Y2kContext())
            {
                this.City = db.City.ToList();
            }
        }
    }
}