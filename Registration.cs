using System;
using System.Collections.Generic;
using System.Text;

namespace To_Do_list
{
    internal class Registration
    {
        public Student student {  get; set; }
        public Courses Courses { get; set; }
        public DateTime Date { get; set; }
    }
    internal class RegistrationSystem
    {
        public event Action<Registration> OnRegistration;
        public void Register(Registration registration)
        {
            Predicate<Registration> reg = r => r.Courses.Fee > 500;
            if (reg(registration))
            {
                OnRegistration(registration);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("No notification needed");
                Console.ResetColor();
            }
        }
    }
}
