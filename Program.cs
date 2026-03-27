namespace To_Do_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Student student = new Student()
         {
             ID = 1,
             Name = "Ahmed",
             Email="Ahmed@gmail.com"
         };
         Courses courses = new Courses()
         {
             id = 101,
             title="C# Beginner",
             Fee=1000
         };
        Registration registration = new Registration()
        {
            student = student,
            Courses = courses
            , Date=DateTime.Now
            
        };
            RegistrationSystem registrationSystem = new RegistrationSystem();
            EmailService emailService = new EmailService();
            WhatsAppService whatsAppService = new WhatsAppService();
            SMSService smsService = new SMSService();
            registrationSystem.OnRegistration += emailService.sendemail;
            registrationSystem.OnRegistration += smsService.sendSMS;
            registrationSystem.OnRegistration += whatsAppService.sendWhatsApp;
            registrationSystem.Register(registration);
        

            
        }
    }

}
