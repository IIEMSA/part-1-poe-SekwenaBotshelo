namespace EventEaseApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Booking
    {
        public int BookingID { get; set; }

        public int VenueID { get; set; }

        public int EventID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual Event Event { get; set; }

        public virtual Venue Venue { get; set; }
    }
}
