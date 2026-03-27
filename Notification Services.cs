using System;
using System.Collections.Generic;
using System.Text;

namespace To_Do_list
{
    internal class EmailService
    {
        public  void sendemail(Registration reg) 
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Email Notification");
            Console.ResetColor();
            Console.WriteLine(reg.Formatmassage());

        }
    }
    internal class SMSService
    {
        public void sendSMS(Registration reg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("SMS Notification");
            Console.ResetColor();
            Console.WriteLine(reg.Formatmassage());

        }
    }
    internal class WhatsAppService
    {
        public void sendWhatsApp(Registration reg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("WhatsApp Notification ");
            Console.ResetColor();
            Console.WriteLine(reg.Formatmassage());
            

        }
    }
}
