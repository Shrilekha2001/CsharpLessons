using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day3
{
    internal class MediaContent
    {
        public virtual void startplayingcontent()
        {
            Console.WriteLine("Start");
        }
        public virtual void stopplayingcontent()
        {
            Console.WriteLine("Stop");
               
        }
        public virtual void pauseplayingcontent()
        {
            Console.WriteLine("Pause");
        }

        public virtual void continueplayingcontent()
        {
            Console.WriteLine("Continue");
        }
        public override string  ToString()
        {
            Console.WriteLine("Media ToString");
            return "OTT";
        }
    }
    internal class Audioncontent : MediaContent
    {
        public override sealed void startplayingcontent()
        {
            Console.WriteLine("Start from Audiocontent");
        }
        //Public override  string ToString(cannot be override because it is sealed)
        //
    }
    internal class Videocontent : MediaContent
    {

    }
    //End 
    internal class Mediatester
    {
        public static void Testone()
        {

        }
    }
    //End of Mediatest class
}
