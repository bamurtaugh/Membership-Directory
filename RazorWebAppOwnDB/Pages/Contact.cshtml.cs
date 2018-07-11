using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWebAppOwnDB.Models;

namespace RazorWebAppOwnDB.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        public Email mails { get; set; }

        public void OnGet()
        {
            Message = "Your contact page.";
        }

        public async Task<IActionResult> OnPost()
        {
            using (var smtp = new SmtpClient())
            {
                smtp.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                smtp.PickupDirectoryLocation = @"c:\MyMail"; // Save emails to local directory
                var msg = new MailMessage
                {
                    Body = mails.Body,
                    Subject = mails.Subject,
                    From = new MailAddress(mails.From)
                };
                msg.To.Add(mails.To);
                await smtp.SendMailAsync(msg);
            }
            // Redirect to page indicating email was sent 
            return RedirectToPage("/EmailExit");
        }
    }
}
