using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BlazorApp
{
    public class Appointment_U
    {
        static int gid = 0;
        [Key]
        public int id { get; set; }
        public int timeslot { get; set; }
        public DateTime Date { get; set; }

        public Appointment_U()
        {
            //gid++;
            //id = gid;
            timeslot = 0;

        }
        public Appointment_U(int timeslot,DateTime Date)
        {
            //gid++;
            //id = gid;
            this.timeslot = timeslot;

            this.Date = Date;
        }
    }
}
