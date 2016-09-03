using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SODemo1.Models
{
    public class MyModel
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Description { get; set; }

        public bool? Accepted { get; set; }
    }
}