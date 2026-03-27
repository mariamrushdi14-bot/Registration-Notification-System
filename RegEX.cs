using System;
using System.Collections.Generic;
using System.Text;

namespace To_Do_list
{
    internal static class RegEX
    {
        public static string Formatmassage(this Registration student)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            return $"Student {student.student.ID} registered in {student.Courses.title} with fee {student.Courses.Fee} ";
            Console.ResetColor();
        }
    }
}
