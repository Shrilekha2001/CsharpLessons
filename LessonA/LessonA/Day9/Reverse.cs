using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day9
{
    internal class Reverse
    {
        public static void classA()
        {
            String strFriends = "Tom and Jerry are good friends";
            var strReverse = strFriends.Reverse();
            foreach (var item in strReverse)
            {
                Console.Write(item);
            }
        }
        public static void QuestionThreeD()
        {
            String strFriends = "Tom and Jerry are good friends";
            string strInUpper = strFriends.ToUpper();
            Console.WriteLine(strFriends);
            Console.WriteLine(strInUpper);
        }
    }
}
