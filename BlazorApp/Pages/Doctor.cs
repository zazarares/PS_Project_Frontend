using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BlazorApp
{
    public class Doctor
    {
        [Key]
        public int id { get; set; }
        [JsonProperty("cnp")]
        public string CNP { get; set; }
        [JsonProperty("firstname")]
        public string FirstName { get; set; }
        [JsonProperty("lastname")]
        public string LastName { get; set; }
        public User_Working U { get; set; }
        public Doctor()
        {
            
        }
        //public User_Working U = new User_Working();


    }
}