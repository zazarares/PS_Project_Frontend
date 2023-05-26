using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace BlazorApp
{
    public class Admin
    {
        [Key]
        public int id { get; set; }

        public Admin() {; }

    }
}