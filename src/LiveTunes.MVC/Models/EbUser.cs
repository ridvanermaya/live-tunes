using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveTunes.MVC.Models
{
    public class Email
    {
        public string email { get; set; }
        public bool verified { get; set; }
        public bool primary { get; set; }
    }

    public class EbUser
    {
        public List<Email> emails { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool is_public { get; set; }
        public object image_id { get; set; }
    }

}
