using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes_Fulton_Christopher
{
    class Greetings
    {
        /// <summary>
        /// 
        /// </summary>
        public void Welcome()
        {
            Console.WriteLine("Hello Traveler, welcome!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void Hello(string name)
        {
            Console.WriteLine($"{name}, Glad you could join us today!)");
        }

    }

}