using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorWebAppOwnDB.Models
{
    public class Email
    {
        // Include To, From, Subject, and Body fields for every Email object created (when email sent)
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
