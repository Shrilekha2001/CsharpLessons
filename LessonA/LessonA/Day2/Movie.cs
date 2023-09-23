using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day2
{
    internal class Movie
    {
        public int Seat { get; set; }
        public string Theatername { get; set; }= string.Empty;
        public string MovieName { get; set; } = string.Empty;
        public string Movietime { get; set; } = string.Empty;
        public override string ToString()
        {
            return $"seat:{Seat}\n Moviename:{MovieName}\n " +
                $"Theatername:{Theatername}\n Movietime:{Movietime}\n";


        }

    }
    internal class show
    {
        public static void Movieone()
        {
            Movie one = new Movie();
            one.Seat = 26 ;
            one.Theatername = "PVR";
            one.MovieName = "abcd";
            one.Movietime = "12.00pm";
            String value= one.ToString();
            Console.WriteLine(value);
        }

    }
}
