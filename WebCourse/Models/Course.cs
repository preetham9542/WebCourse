using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCourse.Models
{
    public class Course
    {
        public int Cid { get; set; }

        public string CName { get; set; }

        public double CFee { get; set; }

        public string Technology { get; set; }

        public DateTime CStartDate { get; set; }

        public DateTime CEndDate { get; set; }

    }
}