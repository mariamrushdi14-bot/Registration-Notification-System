 # Registration Notification System 
 ### 1. "Student" Class 
 Represent a student
  ``` C#
    internal class Student
    {
        public int ID {  get; set; }
        public string Name {  get; set; }
        public string Email {  get; set; }
    }
}
###Courses
 Represent a course
    internal class Courses
    {
        public int id {  get; set; }
        public string title { get; set; }
        public decimal Fee { get; set; }
    }
}
### Registration
Represents a registration record
 internal class Registration
 {
     public Student student {  get; set; }
     public Courses Courses { get; set; }
     public DateTime Date { get; set; }
 }
### RegistrationSystem
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
Key point :
Predicate<Registration> checks the fee condition (> 500).
OnRegistration is an event that multiple services can to  subscribe.

 ###
