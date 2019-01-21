using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.DTO
{
    public class Registration
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CollegeName { get; set; }
    }
}
